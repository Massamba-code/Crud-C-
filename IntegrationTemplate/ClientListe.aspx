<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ClientListe.aspx.cs" Inherits="IntegrationTemplate.ClientListe" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main>
        <div class="row">
            <div class="col-md-12">
                <h2>Liste des Clients
                    <a href="Client.aspx" class="btn btn-success float-right" style="margin-left: 20px;">
                 <i class="fa fa-plus"></i> Add
                    </a>
                </h2>
                 <form id="form1" runat="server">
                <asp:GridView ID="clientGridView" runat="server" AutoGenerateColumns="False" OnRowCommand="clientGridView_RowCommand" CssClass="table table-bordered table-striped" DataKeyNames="id_client">
                    <Columns>
                        <asp:BoundField DataField="nom" HeaderText="Nom" />
                        <asp:BoundField DataField="prenom" HeaderText="Prénom" />
                        <asp:BoundField DataField="adresse" HeaderText="Adresse" />
                        <asp:BoundField DataField="telephone" HeaderText="Téléphone" />
            
                        <asp:TemplateField HeaderText="Actions">
    <ItemTemplate>
        <asp:LinkButton ID="btnEdit" runat="server" CommandName="EditClient"
            CommandArgument='<%# Eval("id_client") %>' CssClass="btn btn-sm btn-warning" ToolTip="Modifier">
            <i class="fa fa-edit"></i>
        </asp:LinkButton>
        &nbsp;
        <asp:LinkButton ID="btnDelete" runat="server" CommandName="DeleteClient"
            CommandArgument='<%#  Eval("id_client") %>' CssClass="btn btn-sm btn-danger" ToolTip="Supprimer"
            OnClientClick="return confirm('Voulez-vous vraiment supprimer ce client ?');">
            <i class="fa fa-trash"></i>
        </asp:LinkButton>
    </ItemTemplate>
</asp:TemplateField>
                    </Columns>
                </asp:GridView>
                     </form>
            </div>
        </div>
    </main>
</asp:Content>
