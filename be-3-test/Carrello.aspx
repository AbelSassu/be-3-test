<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Template.Master" AutoEventWireup="true" CodeBehind="Carrello.aspx.cs" Inherits="be_3_test.Carrello" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="my-5 mx-5">
        <asp:Literal ID="lblEmptyCart" runat="server"></asp:Literal>
    </div>
    <ul id="htmlContent" runat="server" class="m-5 w-50">
        <asp:Repeater ID="rptCartItems" runat="server" OnItemCommand="rptCartItems_ItemCommand">
            <ItemTemplate>
                <li class="d-flex justify-content-around align-items-center">
                    <img class="w-25 h-25" src='<%# Eval("Immagine") %>' alt="Product Image" />
                    <p><%# Eval("Nome") %></p>
                    <div class="d-flex mb-2 align-items-baseline">
                        <p class="d-flex me-1"><%# Eval("Prezzo") %>€</p>
                        <asp:Button runat="server" CommandName="Delete" CommandArgument='<%# Eval("ID") %>'
                            CssClass="btn btn-danger w-75 ms-2" Text="Elimina" OnClientClick="return confirm('Sei sicuro di voler eliminare questo elemento?');" />
                    </div>
                </li>
            </ItemTemplate>
        </asp:Repeater>
    </ul>
    <div id="contentTot" runat="server" class="my-5 mx-5"></div>

</asp:Content>
