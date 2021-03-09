<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Menu.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Site_Vinhao.ASP.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main_content" runat="server">
    <asp:Login ID="loginUtilizador" runat="server" FailureText="Sua tentativa de login não teve sucesso. Por favor, tente novamente." LoginButtonText="Entrar" OnLoggedIn="loginUtilizador_LoggedIn" PasswordRequiredErrorMessage="Escreva a sua Password." RememberMeText="Lembrar-me a proxima vez." UserNameRequiredErrorMessage="Escreva o UserName">
    </asp:Login>
    <a href="Criar_Conta.aspx">Criar Conta</a>
</asp:Content>
