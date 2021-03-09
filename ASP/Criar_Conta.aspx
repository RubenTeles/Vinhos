<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Menu.Master" AutoEventWireup="true" CodeBehind="Criar_Conta.aspx.cs" Inherits="Site_Vinhao.Criar_Conta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main_content" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Nome"></asp:Label>
<asp:TextBox ID="txNome" runat="server" placeholder="Nome" TabIndex="1"></asp:TextBox>
    <asp:RequiredFieldValidator ID="validarNome" runat="server" ErrorMessage="Obrigatório" ControlToValidate="txNome" ValidationGroup="Validar" SetFocusOnError="True" ForeColor="#FF3300"></asp:RequiredFieldValidator>
<br />
<asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
<asp:TextBox ID="txEmail" runat="server" TextMode="Email" placeholder="Email" TabIndex="2"></asp:TextBox>
    <asp:RequiredFieldValidator ID="validarEmail" runat="server" ErrorMessage="Obrigatório" ControlToValidate="txEmail" ValidationGroup="Validar" SetFocusOnError="True" ForeColor="#FF3300"></asp:RequiredFieldValidator>
<br />
<asp:Label ID="Label3" runat="server" Text="Data de Nascimento"></asp:Label>
<asp:TextBox ID="txDatadeNascimento" runat="server" TextMode="Date" placeholder="Data de Nascimento" TabIndex="3"></asp:TextBox>
    <asp:CompareValidator ID="validarDataNascimento" runat="server" ControlToValidate="txDatadeNascimento" ErrorMessage="Obrigatório" ForeColor="#FF3300" ValidationGroup="Validar"></asp:CompareValidator>
<br />
<asp:Label ID="Label4" runat="server" Text="Username" placeholder="UserName"></asp:Label>
<asp:TextBox ID="txUsername" runat="server" TabIndex="4"></asp:TextBox>
    <asp:RequiredFieldValidator ID="validarUsername" runat="server" ErrorMessage="Obrigatório" ControlToValidate="txUsername" ValidationGroup="Validar" SetFocusOnError="True" ForeColor="#FF3300"></asp:RequiredFieldValidator>
<br />
<asp:Label ID="Label5" runat="server" Text="Password" placeholder="Password"></asp:Label>
<asp:TextBox ID="txPassword" runat="server" TextMode="Password" TabIndex="5"></asp:TextBox>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txPassword" ErrorMessage="A sua Password tem de conter no minimo 7 caracteres, um caracter maiusculo, numeros e um caracter especial" ForeColor="#FF3300" ValidationExpression="(?=^.{8,}$)(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&amp;*()_+-}{&quot;:;'?/&gt;.&lt;,])(?!.*\s).*$" ValidationGroup="Validar"></asp:RegularExpressionValidator>
<br />

<asp:Label ID="Label6" runat="server" Text="Confirmar Password" placeholder="Confirme a Password"></asp:Label>
<asp:TextBox ID="txConfirmarPassword" runat="server" TextMode="Password" TabIndex="6"></asp:TextBox>
    <asp:CompareValidator ID="validarConfirmarPassword" runat="server" ControlToCompare="txPassword" ControlToValidate="txConfirmarPassword" ErrorMessage="&quot;Password&quot; e &quot;Confirmar Password&quot; não são iguais" ForeColor="#FF3300" ValidationGroup="Validar"></asp:CompareValidator>

<br />
<br />
<asp:Button ID="btCriarConta" runat="server" OnClick="btCriarConta_Click" Text="Criar Conta" ValidationGroup="Validar" TabIndex="7"/>
</asp:Content>
