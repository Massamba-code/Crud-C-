using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using IntegrationTemplate.Models;

namespace IntegrationTemplate
{
    public partial class ClientListe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ChargerClients();
        }
        private void ChargerClients()
        {
            using (var db = new VenteDBEntities())
            {
                var clients = db.Client.ToList(); // ou db.Client.OrderBy(c => c.nom).ToList();
                clientGridView.DataSource = clients;
                clientGridView.DataBind();
            }
        }
        public void deleteClient()
        {

        }

        protected void clientGridView_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName== "EditClient")
            {
               
                //var client = db.Client.Find(id);
                Response.Redirect("Client.aspx?id=" + id);
            }else if(e.CommandName == "DeleteClient")
            {
                using (var db = new VenteDBEntities())
                {
                    var client = db.Client.Find(id);
                    if (client != null)
                    {
                        db.Client.Remove(client);
                        db.SaveChanges();
                    }
                    ChargerClients();
                }
            }
        }
    }
    
    }
    
