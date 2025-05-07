using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IntegrationTemplate.Models;

namespace IntegrationTemplate
{
    public partial class ProduitListe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ChargerProuct();

        }
        public void ChargerProuct()
        {
            using (var db = new VenteDBEntities())
            {
                var product=db.Produit.ToList();
                productGridView.DataSource = product;
                productGridView.DataBind();
            }
        }
        public void productGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "EditProd")
            {
                Response.Redirect("Produit.aspx?id=" + id);
            }
            else
            {
                using (var db = new VenteDBEntities())
                {
                    var product= db.Produit.Find(id);
                    if (product != null) { 
                        db.Produit.Remove(product);
                        db.SaveChanges();
                    }
                    ChargerProuct();
                }
            }
        }
    }
}