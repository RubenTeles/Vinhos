<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Menu.Master" AutoEventWireup="true" CodeBehind="Criar_Vinho.aspx.cs" Inherits="Site_Vinhao.UtilizadoresRegistados.Criar_Vinho" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../CSS/Criar_VinhoCSS.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main_content" runat="server">
    <br />
    <asp:Label ID="lbTitulo" runat="server" Text="Criar Vinho"></asp:Label>
    <br />
    <br />
    <br />
    <div id="conteudo-esquerda-label">
        <asp:Label ID="Label2" runat="server" Text="Nome:"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Descrição:"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="Label10" runat="server" Text="Foto: "></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Produtor: "></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Tipo de Vinho: "></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" Text="Temperatura: "></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label8" runat="server" Text="Teor Alcoólico: "></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="Label12" runat="server" Text="Castas:"></asp:Label>
    </div>

    <div id="conteudo-esquerda">
        <asp:TextBox ID="txNome" runat="server" Width="400px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="txNome" ErrorMessage="Obrigatório" ValidationGroup="Validar"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:TextBox ID="txDescricao" runat="server" TextMode="MultiLine" Width="400px" Height="123px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="txDescricao" ErrorMessage="Obrigatório" ValidationGroup="Validar"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:FileUpload ID="uploadFoto" runat="server" />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="uploadFoto" ErrorMessage="Obrigatório" ValidationGroup="Validar"></asp:RequiredFieldValidator>
        <br />
        <br />
        <br />
        <asp:DropDownList ID="cbProdutor" runat="server" Width="144px">
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="cbProdutor" ErrorMessage="Obrigatório" ValidationGroup="Validar"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:DropDownList ID="cbTipo" runat="server" Width="164px">
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="cbTipo" ErrorMessage="Obrigatório" ValidationGroup="Validar"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:TextBox ID="txTemperatura" runat="server" Width="86px"></asp:TextBox>
        ºC<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txTemperatura" ErrorMessage="Obrigatório" ValidationGroup="Validar"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:TextBox ID="txTeorAlcoolico" runat="server" TextMode="Number" Width="66px"></asp:TextBox>
        %vol<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txTeorAlcoolico" ErrorMessage="Obrigatório" ValidationGroup="Validar"></asp:RequiredFieldValidator>
        <br />
        <br />
        <br />
        <asp:ListBox ID="lbxCastas" runat="server" Height="220px" Width="250px" SelectionMode="Multiple"></asp:ListBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="lbxCastas" ErrorMessage="Obrigatório" ValidationGroup="Validar"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lbPercentagemTotal" runat="server"></asp:Label>
        <asp:Label ID="lbPercentagem" runat="server"></asp:Label>
    </div>
    <div id="conteudo-direita-label">
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Ano: "></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Região: "></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="Label9" runat="server" Text="Volume: "></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="Label11" runat="server" Text="Enologos:"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="btInserir" runat="server" Height="43px" Text="Inserir" Width="93px" OnClick="btInserir_Click" ValidationGroup="Validar" />

    </div>
    <div id="conteudo-direita">

        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />

        <asp:TextBox ID="txAno" runat="server" TextMode="Number" Width="86px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txAno" ErrorMessage="Obrigatório" ValidationGroup="Validar"></asp:RequiredFieldValidator>
        <br />
        <br />

        <asp:DropDownList ID="cbRegiao" runat="server" Width="136px">
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="cbRegiao" ErrorMessage="Obrigatório" ValidationGroup="Validar"></asp:RequiredFieldValidator>
        <br />
        <br />

        <asp:TextBox ID="txVolume" runat="server" TextMode="Number" Width="86px"></asp:TextBox>
        ml<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txVolume" ErrorMessage="Obrigatório" ValidationGroup="Validar"></asp:RequiredFieldValidator>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:ListBox ID="lbxEnologos" runat="server" Height="220px" Width="250px" SelectionMode="Multiple"></asp:ListBox>
        <asp:RequiredFieldValidator ID="validarEnologos" runat="server" ControlToValidate="lbxEnologos" ErrorMessage="Obrigatório" ValidationGroup="Validar"></asp:RequiredFieldValidator>
        <br />
    </div>
    


</asp:Content>
