<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/MasterPage.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Site_Vinhao.ASP.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main_content" runat="server">
    <asp:Login ID="loginUtilizador" runat="server" FailureText="Sua tentativa de login não teve sucesso. Por favor, tente novamente." LoginButtonText="Entrar" OnLoggedIn="loginUtilizador_LoggedIn" PasswordRequiredErrorMessage="Escreva a sua Password." RememberMeText="Lembrar-me a proxima vez." UserNameRequiredErrorMessage="Escreva o UserName" CreateUserText="Criar Conta" CreateUserUrl="~/ASP/Criar_Conta.aspx">
    </asp:Login>
</asp:Content>
