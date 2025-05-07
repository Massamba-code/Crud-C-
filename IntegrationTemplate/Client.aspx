<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Client.aspx.cs" Inherits="IntegrationTemplate.Client" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main>
        <div class="row">
            <div class="col-md-12">
                <div class="card card-primary">
                    <div class="card-header">
                    <h3 class="card-title" runat="server" id="titre">
                         Ajout Client <small>Veuillez renseigner les informations du client</small>
                    </h3>
                    </div>
                    <form id="myForm" runat="server">
                        <div class="card-body">
                            <div class="form-group">
                                <label for="nomTbx">Nom</label>
                                <asp:TextBox ID="nomTbx" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="prenomTbx">Prenom</label>
                                <asp:TextBox ID="prenomTbx" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="adresseTbx">Adresse</label>
                                <asp:TextBox ID="adresseTbx" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="telephoneTbx">Telephone</label>
                                <asp:TextBox ID="telephoneTbx" runat="server" CssClass="form-control"></asp:TextBox>
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
