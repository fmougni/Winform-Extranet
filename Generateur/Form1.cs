using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generateur
{
    public partial class Form1 : Form
    {
        public static HttpClient ClientHttp = new HttpClient();
        string CheminFichier { get; set;}
        Fichier ExpFichier = new Fichier();
        Dictionary<string,Fichier> ListeFichiers { get; set;}
        public Form1()
        {
            
            InitializeComponent();
            
        }
        bool flag = false;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {//Check if Flag is True ??? if so then make form position same
            //as Cursor position
            if (flag == true)
            {
                this.Location = Cursor.Position;
            }
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }
        //Bouton Enregistrer
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Session();
        }
        private void Session()
        {
            // On charge les fichier 
            this.ListeFichiers = afficherFichiers();
            var fichiers = this.ListeFichiers.Values;
            //ListCloudFichier.Columns.Add("REF_FICHIER", "REF_FICHIER");
            //ListCloudFichier.Columns.Add("NOM_FICHIER", "NOM_FICHIER");
            foreach (Fichier F in fichiers)
            {
                ListCloudFichier.Rows.Add(F.REFFICHIER,F.NOM_FICHIER);
            }
            
            
        }
        //Bouton se Connecter
       

        // Afficher la liste des fichiers visible par l'utilisateur
        private Dictionary<string,Fichier> afficherFichiers()
        {
            int i = 1;
            Dictionary<string, Fichier> ListeFichiers = new Dictionary<string, Fichier>();
            string jsonString = "";
            //Appel API pour récupérer les fichiers sur le cloud
            ClientHttp.DefaultRequestHeaders.Clear();
            ClientHttp.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            ClientHttp.DefaultRequestHeaders.Add("TOKEN", Utilisateur.TokenSession);
            List<Fichier> Fichiers = new List<Fichier>();
            var task = ClientHttp.GetStringAsync("https://localhost:44372/api/Partage?CodeClient=" + Utilisateur.CodeClient)
                .ContinueWith((taskwithresponse) =>
                {
                    var response = taskwithresponse;

                    string json = response.Result;
                    //On convertit en string car sinon bug
                    jsonString = JsonConvert.DeserializeObject<string>(json);
                    //On récupère les fichiers déposés sur l'espaces de partage 

                    Fichiers = JsonConvert.DeserializeObject<List<Fichier>>(jsonString);
                });
            task.Wait();
            foreach (Fichier F in Fichiers)
            {   while(ListeFichiers.ContainsKey(i))
                ListeFichiers.Add(i.ToString(), F);
            }

            //Implémentation en dure pour tester--------------------------------------------------------------------------------------------------------------------------------------------------
            //ListeFichiers.Add("1",new Fichier()
            //{ REFFICHIER = "1",NOM_FICHIER = "Liste_Facture_du_mois_de_Janvier2022.pdf",type = "pdf",DATE_ENREGISTREMENT = DateTime.Now.Date.AddMonths(5), CODECLIENT = "Admin",DESCRIPTION = "Liste des Factures  comptabilisé du 01/01/2022 au 31/01/2022", REFABONNE ="1234", TAILLE = "12090" });
            //ListeFichiers.Add("2",new Fichier()
            //{REFFICHIER = "2",NOM_FICHIER = "Liste_Facture_du_mois_de_Fevrier2022.pdf",type = "pdf",DATE_ENREGISTREMENT = DateTime.Now.Date.AddYears(1), CODECLIENT = "Admin", DESCRIPTION = "Liste des Factures  comptabilisé du 01/02/2022 au 28/02/2022",REFABONNE = "1234", TAILLE = "1303" });
            //ListeFichiers.Add("3",new Fichier()
            //{ REFFICHIER = "3",NOM_FICHIER = "Liste_Facture_du_mois_de_Mars2022.pdf",type = "pdf",DATE_ENREGISTREMENT = DateTime.Now.Date,CODECLIENT = "Admin", DESCRIPTION = "Liste des Factures  comptabilisé du 01/01/2022 au 31/03/2022",REFABONNE = "1234",TAILLE="5203"});
            //ListeFichiers.Add("4",new Fichier()
            //{REFFICHIER = "4",NOM_FICHIER = "Liste_Bulletin_de_Paie_mois_de_Janvier2022.pdf",type = "pdf",DATE_ENREGISTREMENT = DateTime.Now.Date.AddDays(10).AddMonths(3).AddYears(2),CODECLIENT = "Admin",DESCRIPTION = "Liste des Bulletin de paie de la société BlackRoch du 01/01/2022 au 31/01/2022",REFABONNE = "1234", TAILLE = "3025" });

            //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            return ListeFichiers;
           
        }

        // Télecharger fichier(s)
        //private  telechargerFichiers()
        //{

        //}

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
              
        }

        private async void Supprimer(object sender, EventArgs e)
        {
            string Json = JsonConvert.SerializeObject(ExpFichier.REFFICHIER, Newtonsoft.Json.Formatting.Indented);
            var HttpContent = new StringContent(Json, Encoding.UTF8, "application/json");

            //Créer une méthode GET dans l'API qui prend en paramètre le REFFICHIER d'un FICHIER POUR DROP EN SQL
            ClientHttp.DefaultRequestHeaders.Clear();
            ClientHttp.DefaultRequestHeaders.Add("Token", Utilisateur.TokenSession);
            ClientHttp.DefaultRequestHeaders.Add("REFFICHIER", ExpFichier.REFFICHIER);
            HttpResponseMessage response = await ClientHttp.PostAsync("https://localhost:44372/api/Partage", HttpContent);

            //Appellez la methode session() pour actualiser la liste de fichier 
            Session();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {

        }

        private void Telecharger(object sender, EventArgs e)
        {
            var NomFichierSansEctension = ExpFichier.NOM_FICHIER.Split('.');
            var filename = NomFichierSansEctension[0];
            //var tempFolder = System.IO.Path.GetTempPath();
            //filename = System.IO.Path.Combine(tempFolder, filename);
            ////System.IO.File.WriteAllBytes(filename, ExpFichier.FICHIER);
            //System.Diagnostics.Process.Start(filename);

            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

                byte[] byteArray = ExpFichier.FICHIER;
                string name = filename;
                saveFileDialog1.FileName = name;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if ((myStream = saveFileDialog1.OpenFile()) != null)
                    {
                        myStream.Write(byteArray, 0, byteArray.Length);
                        myStream.Close();
                    }
                }

                //File.WriteAllBytes("Path\\" + name, byteArray);
            }
        

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
        //Enregistrer fichier dans le cloud
        private void btnImporter_Click(object sender, EventArgs e)
        {
            try
            {   
                var task = Task.Run(async () => await ImporterFichier(ExpFichier.FICHIER, ExpFichier.NOM_FICHIER, ExpFichier.TAILLE, ExpFichier.type, ExpFichier.CODECLIENT, ExpFichier.DESCRIPTION));
                MessageBox.Show("Import terminée avec succès");
                Session();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public async Task ImporterFichier(byte[] file, string NOM_FICHIER, string Taille, string TYPE, string CODECLIENT, string DESCRIPTION)
        {
            ClientHttp.DefaultRequestHeaders.Clear();
            string Json = JsonConvert.SerializeObject(file, Newtonsoft.Json.Formatting.Indented);
            var HttpContent = new StringContent(Json, Encoding.UTF8, "application/json");

            ClientHttp.DefaultRequestHeaders.Add("Token", Utilisateur.TokenSession);
            ClientHttp.DefaultRequestHeaders.Add("NOM_FICHIER", NOM_FICHIER);
            ClientHttp.DefaultRequestHeaders.Add("Taille", Taille);
            ClientHttp.DefaultRequestHeaders.Add("TYPE", TYPE);
            ClientHttp.DefaultRequestHeaders.Add("CODECLIENT", CODECLIENT);
            ClientHttp.DefaultRequestHeaders.Add("DESCRIPTION", DESCRIPTION);
            HttpResponseMessage response = await ClientHttp.PostAsync("https://localhost:44372/api/Partage", HttpContent);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_2(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOuvrir_Click_1(object sender, EventArgs e)
        {
            try {
                OpenFileDialog ofd = new OpenFileDialog();
                //ofd.Filter = "Text files (*.pdf) | *.txt";
                ofd.ShowDialog();
                
                string[] NomFichier = ofd.FileName.Split('\\');
                TextFile.Text = NomFichier[NomFichier.Length-1];
                this.CheminFichier = ofd.FileName;
                actualiserFichier();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
        private void actualiserFichier()
        {
            FileInfo fi = new FileInfo(CheminFichier);
            this.ExpFichier.FICHIER = File.ReadAllBytes(CheminFichier);
            this.ExpFichier.NOM_FICHIER = fi.Name;
            this.ExpFichier.type = fi.Extension;
            this.ExpFichier.DATE_ENREGISTREMENT = DateTime.Now;
            this.ExpFichier.TAILLE = fi.Length.ToString();
            this.ExpFichier.CODECLIENT = Utilisateur.CodeClient;
            this.ExpFichier.DESCRIPTION = "";
            //on actualise les champs
            actualiserChamps(ExpFichier);
           
        }

        private void actualiserChamps(Fichier E)
        {
            var NomFichierSansEctension = E.NOM_FICHIER.Split('.');
            Nom_Fichier.Text = NomFichierSansEctension[0];
            label4.Text = E.type;
            Taille_Fichier.Text = E.TAILLE;
            Date_Fichier.Text = E.DATE_ENREGISTREMENT.ToString();
            Description_Fichier.Text = E.DESCRIPTION;
        }

        private void Description_Fichier_TextChanged(object sender, EventArgs e)
        {
            this.ExpFichier.DESCRIPTION = Description_Fichier.Text;
        }

        private void Nom_Fichier_TextChanged(object sender, EventArgs e)
        {
            this.ExpFichier.NOM_FICHIER = Nom_Fichier.Text;
        }

        private void Type_Fichier_TextChanged(object sender, EventArgs e)
        {
            this.ExpFichier.type = label4.Text;
        }

        private void Taille_Fichier_TextChanged(object sender, EventArgs e)
        {
            this.ExpFichier.TAILLE = Taille_Fichier.Text;
        }

        private void button3_Click_2(object sender, EventArgs e)
        {

        }

        private void label4_Click_3(object sender, EventArgs e)
        {

        }

   
   

        private void ListCloudFichier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {  if (e.RowIndex > 0)
            {
                var a = ListCloudFichier.Rows[e.RowIndex].Cells["REF_FICHIER"].Value.ToString();
                Fichier E = new Fichier();
                ListeFichiers.TryGetValue(a, out E);
                actualiserChamps(E);
            }
        }

        private void splitContainer1_Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SeDeconnecter_Click(object sender, EventArgs e)
        {   
            this.Hide();
           new Login().Show();
        }

        private void Enregistrer_Click_1(object sender, EventArgs e)
        {

        }
    }
}
