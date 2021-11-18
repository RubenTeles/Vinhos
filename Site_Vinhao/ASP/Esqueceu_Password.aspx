<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/MasterPage.Master" AutoEventWireup="true" CodeBehind="Esqueceu_Password.aspx.cs" Inherits="Site_Vinhao.UtilizadoresRegistados.Editar_Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main_content" runat="server">
  
    <br /><br /><br />
        <asp:PasswordRecovery ID="PasswordRecovery1" runat="server" AnswerLabelText="Responda:" AnswerRequiredErrorMessage="
A resposta é obrigatória." GeneralFailureText="
Sua tentativa de recuperar sua senha não foi bem-sucedida. Por favor, tente novamente." QuestionFailureText="Não foi possível verificar sua resposta. Por favor, tente novamente." QuestionInstructionText="Responda a seguinte pergunta para receber sua senha." QuestionLabelText="Pergunta:" QuestionTitleText="
Confirmação de Identidade" SubmitButtonText="Enviar" SuccessText="
Sua senha foi enviada para você." UserNameFailureText="
Não foi possível acessar suas informações. Por favor, tente novamente." UserNameInstructionText="Digite seu nome de usuário para receber sua senha." UserNameRequiredErrorMessage="User Name é obrigatório." UserNameTitleText="Esqueceu sua senha?" Enabled="False">
</asp:PasswordRecovery>

</asp:Content>
