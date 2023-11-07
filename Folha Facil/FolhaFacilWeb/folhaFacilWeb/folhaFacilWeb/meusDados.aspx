<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMestra.Master" AutoEventWireup="true" CodeBehind="meusDados.aspx.cs" Inherits="folhaFacilWeb.meusDados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link href="Styles/meusDados.css" rel="stylesheet" />

    <div class="conteiner">
        <h1>Seus Dados</h1>

        <h3>Nome:&nbsp; <asp:Label ID="lblNome" runat="server" Text=" Label"></asp:Label>
        </h3>
        <h3>Status das Ferias:  
        <asp:Label ID="lblStatusFerias" runat="server" Text="Label"></asp:Label>
        </h3>
        <h3>Periodo de Ferias:<asp:Label ID="lblPeriodoFerias" runat="server" Text="Label"></asp:Label>
        </h3>
        <h3>&nbsp;</h3>
    </div>

</asp:Content>


