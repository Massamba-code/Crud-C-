<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Produit.aspx.cs" Inherits="IntegrationTemplate.Produit" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main>
        <div class="row">
            <div class="col-md-12">
                <div class="card card-primary">
                    <div class="card-header">
                    <h3 class="card-title" runat="server" id="titre">
                         Ajout Produit <small>Veuillez renseigner les informations du produit</small>
                    </h3>
                    </div>
                    <form id="myForm" runat="server">
                        <div class="card-body">
                            <div class="form-group">
                                <label for="libelleTbx">Libelle</label>
                                <asp:TextBox ID="libelleTbx" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="prixTbx">Prix</label>
                                <asp:TextBox ID="prixTbx" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="qteTbx">Quantite</label>
                                <asp:TextBox ID="qteTbx" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                            </div>
                           



                        </div>
                        <!-- /.card-body -->

                        <div class="card-footer">
                            <asp:Button ID="submitBtn" runat="server" Text="Soumettre" CssClass="btn btn-primary"  OnClick="submitBtn_Click"/>
                        </div>
                    </form>
                </div>
            </div>

        </div>
    </main>

</asp:Content>
