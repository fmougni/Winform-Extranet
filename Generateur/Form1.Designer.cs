
namespace Generateur
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.InfoLog = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Ouvrir = new System.Windows.Forms.Button();
            this.ListCloudFichier = new System.Windows.Forms.DataGridView();
            this.REF_FICHIER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.Importer = new System.Windows.Forms.Button();
            this.TextFile = new System.Windows.Forms.TextBox();
            this.Date_Fichier = new System.Windows.Forms.Label();
            this.Taille_Fichier = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Enregistrer = new System.Windows.Forms.Button();
            this.label_description = new System.Windows.Forms.Label();
            this.Taille = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.NomFichier = new System.Windows.Forms.Label();
            this.Nom_Fichier = new System.Windows.Forms.TextBox();
            this.Description_Fichier = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SeDeconnecter = new System.Windows.Forms.Button();
            this.Quitter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListCloudFichier)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-2510, -98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // InfoLog
            // 
            this.InfoLog.AutoSize = true;
            this.InfoLog.Location = new System.Drawing.Point(938, 41);
            this.InfoLog.Name = "InfoLog";
            this.InfoLog.Size = new System.Drawing.Size(0, 20);
            this.InfoLog.TabIndex = 7;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.progressBar1.Location = new System.Drawing.Point(1, 718);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1622, 33);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 8;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 109);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Ouvrir);
            this.splitContainer1.Panel1.Controls.Add(this.ListCloudFichier);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.Importer);
            this.splitContainer1.Panel1.Controls.Add(this.TextFile);
            this.splitContainer1.Panel1.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint_1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Date_Fichier);
            this.splitContainer1.Panel2.Controls.Add(this.Taille_Fichier);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.Enregistrer);
            this.splitContainer1.Panel2.Controls.Add(this.label_description);
            this.splitContainer1.Panel2.Controls.Add(this.Taille);
            this.splitContainer1.Panel2.Controls.Add(this.date);
            this.splitContainer1.Panel2.Controls.Add(this.Type);
            this.splitContainer1.Panel2.Controls.Add(this.NomFichier);
            this.splitContainer1.Panel2.Controls.Add(this.Nom_Fichier);
            this.splitContainer1.Panel2.Controls.Add(this.Description_Fichier);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1598, 582);
            this.splitContainer1.SplitterDistance = 527;
            this.splitContainer1.TabIndex = 9;
            // 
            // Ouvrir
            // 
            this.Ouvrir.BackColor = System.Drawing.Color.MediumPurple;
            this.Ouvrir.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Ouvrir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Ouvrir.Location = new System.Drawing.Point(13, 533);
            this.Ouvrir.Name = "Ouvrir";
            this.Ouvrir.Size = new System.Drawing.Size(97, 37);
            this.Ouvrir.TabIndex = 5;
            this.Ouvrir.Text = "Ouvrir";
            this.Ouvrir.UseVisualStyleBackColor = false;
            this.Ouvrir.Click += new System.EventHandler(this.btnOuvrir_Click_1);
            // 
            // ListCloudFichier
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ListCloudFichier.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ListCloudFichier.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ListCloudFichier.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ListCloudFichier.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ListCloudFichier.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumOrchid;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListCloudFichier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ListCloudFichier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListCloudFichier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.REF_FICHIER,
            this.dataGridViewTextBoxColumn1});
            this.ListCloudFichier.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListCloudFichier.DefaultCellStyle = dataGridViewCellStyle3;
            this.ListCloudFichier.GridColor = System.Drawing.Color.MidnightBlue;
            this.ListCloudFichier.Location = new System.Drawing.Point(7, 49);
            this.ListCloudFichier.MultiSelect = false;
            this.ListCloudFichier.Name = "ListCloudFichier";
            this.ListCloudFichier.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListCloudFichier.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ListCloudFichier.RowHeadersVisible = false;
            this.ListCloudFichier.RowHeadersWidth = 51;
            this.ListCloudFichier.RowTemplate.Height = 29;
            this.ListCloudFichier.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ListCloudFichier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListCloudFichier.Size = new System.Drawing.Size(517, 477);
            this.ListCloudFichier.TabIndex = 4;
            this.ListCloudFichier.UseWaitCursor = true;
            this.ListCloudFichier.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListCloudFichier_CellContentClick);
            // 
            // REF_FICHIER
            // 
            this.REF_FICHIER.HeaderText = "REF_FICHIER";
            this.REF_FICHIER.MinimumWidth = 6;
            this.REF_FICHIER.Name = "REF_FICHIER";
            this.REF_FICHIER.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "NOM_FICHIER";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 400;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.MediumPurple;
            this.label5.Location = new System.Drawing.Point(123, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(267, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Liste des fichiers sur le cloud";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Importer
            // 
            this.Importer.BackColor = System.Drawing.Color.Gray;
            this.Importer.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Importer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Importer.Location = new System.Drawing.Point(422, 532);
            this.Importer.Name = "Importer";
            this.Importer.Size = new System.Drawing.Size(96, 37);
            this.Importer.TabIndex = 1;
            this.Importer.Text = "Importer";
            this.Importer.UseVisualStyleBackColor = false;
            this.Importer.Click += new System.EventHandler(this.btnImporter_Click);
            // 
            // TextFile
            // 
            this.TextFile.Location = new System.Drawing.Point(116, 539);
            this.TextFile.Name = "TextFile";
            this.TextFile.Size = new System.Drawing.Size(300, 27);
            this.TextFile.TabIndex = 0;
            // 
            // Date_Fichier
            // 
            this.Date_Fichier.AutoSize = true;
            this.Date_Fichier.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Date_Fichier.ForeColor = System.Drawing.Color.MediumPurple;
            this.Date_Fichier.Location = new System.Drawing.Point(762, 22);
            this.Date_Fichier.Name = "Date_Fichier";
            this.Date_Fichier.Size = new System.Drawing.Size(125, 20);
            this.Date_Fichier.TabIndex = 16;
            this.Date_Fichier.Text = ".............................";
            // 
            // Taille_Fichier
            // 
            this.Taille_Fichier.AutoSize = true;
            this.Taille_Fichier.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Taille_Fichier.ForeColor = System.Drawing.Color.MediumPurple;
            this.Taille_Fichier.Location = new System.Drawing.Point(637, 22);
            this.Taille_Fichier.Name = "Taille_Fichier";
            this.Taille_Fichier.Size = new System.Drawing.Size(57, 20);
            this.Taille_Fichier.TabIndex = 15;
            this.Taille_Fichier.Text = "............";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.MediumPurple;
            this.label4.Location = new System.Drawing.Point(525, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = ".........";
            this.label4.Click += new System.EventHandler(this.label4_Click_3);
            // 
            // Enregistrer
            // 
            this.Enregistrer.BackColor = System.Drawing.Color.MediumPurple;
            this.Enregistrer.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Enregistrer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Enregistrer.Location = new System.Drawing.Point(930, 49);
            this.Enregistrer.Name = "Enregistrer";
            this.Enregistrer.Size = new System.Drawing.Size(134, 44);
            this.Enregistrer.TabIndex = 13;
            this.Enregistrer.Text = "Enregistrer";
            this.Enregistrer.UseVisualStyleBackColor = false;
            this.Enregistrer.Click += new System.EventHandler(this.Enregistrer_Click_1);
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.Location = new System.Drawing.Point(28, 78);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(85, 20);
            this.label_description.TabIndex = 12;
            this.label_description.Text = "Description";
            // 
            // Taille
            // 
            this.Taille.AutoSize = true;
            this.Taille.Location = new System.Drawing.Point(588, 21);
            this.Taille.Name = "Taille";
            this.Taille.Size = new System.Drawing.Size(43, 20);
            this.Taille.TabIndex = 11;
            this.Taille.Text = "Taille";
            this.Taille.Click += new System.EventHandler(this.label4_Click_2);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(715, 22);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(41, 20);
            this.date.TabIndex = 10;
            this.date.Text = "Date";
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(479, 21);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(40, 20);
            this.Type.TabIndex = 9;
            this.Type.Text = "Type";
            this.Type.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // NomFichier
            // 
            this.NomFichier.AutoSize = true;
            this.NomFichier.Location = new System.Drawing.Point(26, 22);
            this.NomFichier.Name = "NomFichier";
            this.NomFichier.Size = new System.Drawing.Size(87, 20);
            this.NomFichier.TabIndex = 8;
            this.NomFichier.Text = "Nom fichier";
            // 
            // Nom_Fichier
            // 
            this.Nom_Fichier.Location = new System.Drawing.Point(119, 18);
            this.Nom_Fichier.Name = "Nom_Fichier";
            this.Nom_Fichier.Size = new System.Drawing.Size(354, 27);
            this.Nom_Fichier.TabIndex = 4;
            this.Nom_Fichier.TextChanged += new System.EventHandler(this.Nom_Fichier_TextChanged);
            // 
            // Description_Fichier
            // 
            this.Description_Fichier.Location = new System.Drawing.Point(119, 78);
            this.Description_Fichier.Name = "Description_Fichier";
            this.Description_Fichier.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.Description_Fichier.Size = new System.Drawing.Size(787, 410);
            this.Description_Fichier.TabIndex = 3;
            this.Description_Fichier.Text = "";
            this.Description_Fichier.TextChanged += new System.EventHandler(this.Description_Fichier_TextChanged);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.MediumPurple;
            this.button2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(15, 518);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(1036, 51);
            this.button2.TabIndex = 2;
            this.button2.Text = "Telecharger le fichier";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.UseWaitCursor = true;
            this.button2.Click += new System.EventHandler(this.Telecharger);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(930, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Supprimer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Supprimer);
            // 
            // SeDeconnecter
            // 
            this.SeDeconnecter.BackColor = System.Drawing.Color.MediumPurple;
            this.SeDeconnecter.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SeDeconnecter.ForeColor = System.Drawing.Color.White;
            this.SeDeconnecter.Location = new System.Drawing.Point(1267, 12);
            this.SeDeconnecter.Name = "SeDeconnecter";
            this.SeDeconnecter.Size = new System.Drawing.Size(172, 77);
            this.SeDeconnecter.TabIndex = 10;
            this.SeDeconnecter.Text = "Se deconnecter";
            this.SeDeconnecter.UseVisualStyleBackColor = false;
            this.SeDeconnecter.Click += new System.EventHandler(this.SeDeconnecter_Click);
            // 
            // Quitter
            // 
            this.Quitter.BackColor = System.Drawing.Color.Gray;
            this.Quitter.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Quitter.ForeColor = System.Drawing.Color.White;
            this.Quitter.Location = new System.Drawing.Point(1435, 12);
            this.Quitter.Name = "Quitter";
            this.Quitter.Size = new System.Drawing.Size(172, 77);
            this.Quitter.TabIndex = 11;
            this.Quitter.Text = "Quitter";
            this.Quitter.UseVisualStyleBackColor = false;
            this.Quitter.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1624, 752);
            this.Controls.Add(this.Quitter);
            this.Controls.Add(this.SeDeconnecter);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.InfoLog);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListCloudFichier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label InfoLog;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label NomFichier;
        private System.Windows.Forms.TextBox Nom_Fichier;
        private System.Windows.Forms.RichTextBox Description_Fichier;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label Taille;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Button Importer;
        private System.Windows.Forms.TextBox TextFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView ListCloudFichier;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.Button Ouvrir;
        private System.Windows.Forms.Button Enregistrer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Date_Fichier;
        private System.Windows.Forms.Label Taille_Fichier;
        private System.Windows.Forms.DataGridViewTextBoxColumn REF_FICHIER;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button SeDeconnecter;
        private System.Windows.Forms.Button Quitter;
    }
}

