using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IntegrationTemplate.Models;

namespace IntegrationTemplate
{
    public partial class Client : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    int id = int.Parse(Request.QueryString["id"]);
                    LoadClient(id);
                    titre.InnerText = "Modifier Client";
                }
                else
                {
                    titre.InnerText = "Ajout Client";
                }
            }

        }
        private void LoadClient(int id)
        {
            using (var db = new VenteDBEntities())
            {
                var client = db.Client.Find(id);
                if (client != null)
                {
                    nomTbx.Text = client.nom;
                    prenomTbx.Text = client.prenom;
                    adresseTbx.Text = client.adresse;
                    telephoneTbx.Text = client.telephone;
                }
            }
        }
        protected void submitBtn_Click(object sender, EventArgs e)
        {
           using (var db = new VenteDBEntities())
            {
                if (Request.QueryString["id"] != null)
                {
                    // Modification
                    int id = int.Parse(Request.QueryString["id"]);
                    var client = db.Client.Find(id);
                    if (client != null)
                    {
                        client.nom = nomTbx.Text.Trim();
                        client.prenom = prenomTbx.Text.Trim();
                        client.adresse = adresseTbx.Text.Trim();
                        client.telephone = telephoneTbx.Text.Trim();
                    }
                }
                else
                {
                    // Ajout
                    var client = new Models.Client
                    {
                        nom = nomTbx.Text.Trim(),
                        prenom = prenomTbx.Text.Trim(),
                        adresse = adresseTbx.Text.Trim(),
                        telephone = telephoneTbx.Text.Trim()
                    };
                    db.Client.Add(client);
                }

                db.SaveChanges();
            }

            Response.Redirect("ClientListe.aspx");
        }
    }
    
}