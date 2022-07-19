using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Generateur
{
    class Authentification
    {
        ClientAuthentifie ClientAuth = null;
        public void AuthentificationUtilisateur(string Login, string Mdp)
        {
            var stringContent = new FormUrlEncodedContent(new[]{
                new KeyValuePair<string, string>("champLogin", Login),
                new KeyValuePair<string, string>("champMdp", Mdp),
            });
            Uri u = new Uri("https://localhost:44372/api/Authentification?Login=" + Login + "&Mdp=" + Mdp);

            //Appel API POST Authentification
            var t = Task.Run(() => PostAuth(u, stringContent));
            t.Wait();
            var rep = t.Result;

            //Vérifie accès
            if (rep == "OK" && ClientAuth != null)
            {
                Utilisateur.TokenSession = ClientAuth.TokenSession;
                Utilisateur.CodeClient = ClientAuth.CodeClient;
            }
        }

        public async Task<string> PostAuth(Uri u, HttpContent c)
        {
            //Récupère Token d'authentification et le CodeClient

            string resp = "";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage res = await client.PostAsync(u, c);
                if (res.IsSuccessStatusCode)
                {
                    resp = res.StatusCode.ToString();

                    var task = res.Content.ReadAsStringAsync().ContinueWith((taskwithresponse) =>
                    {
                        var response = taskwithresponse;

                        string json = response.Result;
                        //On convertit en string car sinon bug
                        string jsonString = JsonConvert.DeserializeObject<string>(json);
                        //On convertit en client pour récup données
                        ClientAuth = JsonConvert.DeserializeObject<ClientAuthentifie>(jsonString);

                    });
                    task.Wait();
                }
            }

            return resp;
        }
    }
}
