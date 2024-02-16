<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Template.Master" AutoEventWireup="true" CodeBehind="Dettaglio.aspx.cs" Inherits="be_3_test.Dettaglio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-lg m-auto mt-3">
        <h2 ID="ttlProduct" runat="server" ></h2>
        <img ID="img" src="www" alt="..." class="w-25 25" runat="server" />
        <p ID="txtDescription" runat="server" > </p>
        <p ID="txtPrice" runat="server" > </p>
        <asp:Button ID="btnAddCart" runat="server" Text="Aggiungi al carrello" CssClass="btn btn-outline-success" OnClick="btnAddCart_Click" />
        
    </div>
    <div class="container-lg m-auto mt-5">
        <asp:Literal ID="lblMessage" runat="server"></asp:Literal>
    </div>
</asp:Content>
