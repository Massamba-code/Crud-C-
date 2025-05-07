<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProduitListe.aspx.cs" Inherits="IntegrationTemplate.ProduitListe" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main>
        <div class="row">
            <div class="col-md-12">
                <h2>Liste des Produits
                    <a href="Produit.aspx" class="btn btn-success float-right" style="margin-left: 20px;">
                 <i class="fa fa-plus"></i> Add
                    </a>
                </h2>
                 <form id="form1" runat="server">
                <asp:GridView ID="productGridView" runat="server" AutoGenerateColumns="False" OnRowCommand="productGridView_RowCommand" CssClass="table table-bordered table-striped" DataKeyNames="id">
                    <Columns>
                        <asp:BoundField DataField="id" HeaderText="#" />
                        <asp:BoundField DataField="libelle" HeaderText="Libelle" />
                        <asp:BoundField DataField="qte" HeaderText="Quantite" />
                        <asp:BoundField DataField="prix" HeaderText="Prix" />
                        <asp:TemplateField HeaderText="Actions">
    <ItemTemplate>
        <asp:LinkButton ID="btnEdit" runat="server" CommandName="EditProd"
            CommandArgument='<%# Eval("id") %>' CssClass="btn btn-sm btn-warning" ToolTip="Modifier">
            <i class="fa fa-edit"></i>
        </asp:LinkButton>
        &nbsp;
        <asp:LinkButton ID="btnDelete" runat="server" CommandName="DeleteProd"
            CommandArgument='<%#  Eval("id") %>' CssClass="btn btn-sm btn-danger" ToolTip="Supprimer"
            OnClientClick="return confirm('Voulez-vous vraiment supprimer ce produit ?');">
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
