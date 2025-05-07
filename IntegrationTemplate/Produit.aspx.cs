using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IntegrationTemplate.Models;

namespace IntegrationTemplate
{
    public partial class Produit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    int id = int.Parse(Request.QueryString["id"]);
                    LoadProduct(id);
                    titre.InnerText = "Modifier Produit";
                }
                else
                {
                    titre.InnerText = "Ajout Produit";
                }
            }
        }
        public void LoadProduct(int id) {
            using (var db = new VenteDBEntities())
            {
                var prod = db.Produit.Find(id);
                if (prod != null)
                {
                    libelleTbx.Text = prod.libelle;
                    qteTbx.Text = prod.qte.ToString();
                    prixTbx.Text = prod.prix.ToString();
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
                    var prod = db.Produit.Find(id);
                    if (prod != null)
                    {
                        prod.libelle = libelleTbx.Text.Trim();
                        prod.qte = int.Parse(qteTbx.Text.Trim());
                        prod.prix = int.Parse(prixTbx.Text.Trim());
                    }
                }
                else
                {
                    // Ajout
                    var prod = new Models.Produit
                    {
                        libelle = libelleTbx.Text.Trim(),
                        qte = int.Parse(qteTbx.Text.Trim()),
                        prix = int.Parse(prixTbx.Text.Trim())
                    };
                    db.Produit.Add(prod);
                }

                db.SaveChanges();
            }

            Response.Redirect("ProduitListe.aspx");
        }
    }
    
}