<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="folhaFacilWeb.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="Styles/styleLogin.css" />
    <title>Folha Facil - Login</title>

    <script type="text/javascript">
                window.history.pushState(null, null, window.location.href);
                window.onpopstate = function () {
                 window.history.pushState(null, null, window.location.href);
        };
    </script>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="mainLogin">
        <div class="leftLogin">
            <h1>Faça Login<br/>Folha Facil Web</h1>
            <img src="images/iconTelaLogin.svg" alt="Astronauta"/>
        </div>
        <div class="rightLogin">
            <div class="cardLogin">
                 <h1>LOGIN</h1>
                <div class="textField">
                    <label for="usuario">Usuário</label>
                    <asp:TextBox ID="txtUsuario" runat="server" CssClass="input" TabIndex="1" placeholder="E-mail"></asp:TextBox>
                </div>
                <div class="textField"> 
                    <label for="senha">Senha</label>
                    <asp:TextBox ID="txtSenha" runat="server" CssClass="input" TabIndex="1" placeholder="Senha" TextMode="Password"></asp:TextBox>
                </div>
                <asp:button class="btnLogin" runat="server" OnClick="btnLogin" Text="Entrar"></asp:button>
                <asp:Label ID="lblMensagemErro" runat="server" Text="Menssagem de erro" CssClass="mensagem-erro" Visible="False" ForeColor="Red"></asp:Label>
            </div>
        </div>
    </div>  
        </div>
    </form>
    
</body>
</html>
