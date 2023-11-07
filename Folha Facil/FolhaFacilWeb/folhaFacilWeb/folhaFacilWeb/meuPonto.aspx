<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMestra.Master" AutoEventWireup="true" CodeBehind="meuPonto.aspx.cs" Inherits="folhaFacilWeb.meuPonto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link rel="stylesheet" href="Styles/stylePonto.css"/>
   
    <div CssClass="main-page-ponto">

        <div class="button">
            <asp:Button  runat="server" Text="Incluir Ponto" CssClass="btnPonto" ID="btnIncluirPonto" OnClick="btnInluirPonto" />
        </div>

        <div class="main-page-ponto" style="align-items:center; justify-content:center" >
            <asp:GridView ID="GvPonto" runat="server" AutoGenerateColumns="False" Width="100%" Height="406px" HorizontalAlign="Center" BackColor="#201B2C" ForeColor="#77FFC0">
                <Columns>
                        <asp:BoundField DataField="data" HeaderText="Data" DataFormatString="{0:dd/MM/yyyy}">
            
                        <HeaderStyle HorizontalAlign="Center" />
                        <ItemStyle Width="200px" HorizontalAlign="Center" VerticalAlign="Middle" />
            
                        </asp:BoundField>
                        <asp:BoundField DataField="entrada" HeaderText="Entrada" SortExpression="entrada" DataFormatString="{0:HH:mm:ss}" >
       
                        <ItemStyle Width="200px" HorizontalAlign="Center" />
       
                        </asp:BoundField>
                        <asp:BoundField DataField="ida" HeaderText="Ida" SortExpression="ida" DataFormatString="{0:HH:mm:ss}" >
  
                        <HeaderStyle Width="200px" />
  
                        <ItemStyle HorizontalAlign="Center" />
  
                        </asp:BoundField>
                        <asp:BoundField DataField="volta" HeaderText="Volta" SortExpression="volta" DataFormatString="{0:HH:mm:ss}" >
 
                        <ItemStyle Width="200px" HorizontalAlign="Center" />
 
                        </asp:BoundField>
                        <asp:BoundField DataField="saida" HeaderText="Saida" SortExpression="saida" DataFormatString="{0:HH:mm:ss}" >
    
                        <HeaderStyle Width="200px" />
    
                        <ItemStyle HorizontalAlign="Center" />
    
                        </asp:BoundField>
                </Columns>
                <HeaderStyle Height="100px" Width="600px" />
                <RowStyle Width="600px" />
            </asp:GridView>
        </div>
    </div>
</asp:Content>
