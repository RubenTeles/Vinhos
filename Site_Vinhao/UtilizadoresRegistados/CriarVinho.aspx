<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/MasterPage.Master" AutoEventWireup="true" CodeBehind="CriarVinho.aspx.cs" Inherits="Site_Vinhao.UtilizadoresRegistados.CriarVinho" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Criar Vinho</title>
    <link href="../CSS/VinhoCSS.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style3 {
            height: 230px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main_content" runat="server">
    <div id="vinho">
        <div id="imagem" class="auto-style3">
            <asp:Image class="imagem" ID="foto" runat="server" alt="Me" ImageAlign="Middle" Width="280px" maxHeight="320" ImageUrl="~/Imagens/Conteudo/garrafa.png" />
            <br />
            <asp:FileUpload ID="uploadFoto" runat="server"/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="uploadFoto" ErrorMessage="Obrigatório" ValidationGroup="Validar" ForeColor="#FF3300"></asp:RequiredFieldValidator>
            <br />
            <br />
            <br />
            <br />
            <br />
            _
        </div>

        <div id="conteudo-1">
            <div id="conteudo-1-1">
                <b>
                    <asp:Label ID="Label27" runat="server" Text="Nome:"></asp:Label></b>
                <asp:TextBox ID="txNome" runat="server" Width="400px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="txNome" ErrorMessage="Obrigatório" ValidationGroup="Validar" ForeColor="#FF3300"></asp:RequiredFieldValidator>
            </div>

            <div id="conteudo-1-3">
                <hr />
                <b>
                    <asp:Label ID="Label1" runat="server" Text="Descrição: "></asp:Label></b><asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="txDescricao" ErrorMessage="Obrigatório" ValidationGroup="Validar" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                <br />
                <asp:TextBox ID="txDescricao" runat="server" TextMode="MultiLine" Width="630px" Height="125px"></asp:TextBox>

                <br />
                <br />
            </div>
        </div>
        <div id="conteudo-2-2">
            <hr />
            <b><asp:Label ID="Label4" runat="server" Text="Tipo de Vinho: "></asp:Label></b>
            <asp:DropDownList ID="cbTipo" runat="server" Width="164px">
            </asp:DropDownList><asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="cbTipo" ErrorMessage="Obrigatório" ValidationGroup="Validar" ForeColor="#FF3300"></asp:RequiredFieldValidator>

            <br />
            <br />
            <b>
                <asp:Label ID="Label10" runat="server" Text="Ano: "></asp:Label></b>
            <asp:TextBox ID="txAno" runat="server" TextMode="Number" Width="86px" min="1900" MaxLength="2100"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txAno" ErrorMessage="Obrigatório" ValidationGroup="Validar" ForeColor="#FF3300"></asp:RequiredFieldValidator>

            <br />
            <br />
            <b>
                <asp:Label ID="Label6" runat="server" Text="Região: "></asp:Label></b>
            <asp:DropDownList ID="cbRegiao" runat="server" Width="136px">
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="cbRegiao" ErrorMessage="Obrigatório" ValidationGroup="Validar" ForeColor="#FF3300"></asp:RequiredFieldValidator>
            <br />
            <br />
            <b>
                <asp:Label ID="Label3" runat="server" Text="Produtor: "></asp:Label></b>
            <asp:DropDownList ID="cbProdutor" runat="server" Width="144px"></asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="cbProdutor" ErrorMessage="Obrigatório" ValidationGroup="Validar" ForeColor="#FF3300"></asp:RequiredFieldValidator>

        </div>

        <div id="conteudo-2-1">
            <hr />
            <b>
                <asp:Label ID="Label7" runat="server" Text="Temperatura: "></asp:Label></b>
            <asp:TextBox ID="txTemperatura" runat="server" Width="86px"></asp:TextBox>
            
                <b><asp:Label ID="Label24" runat="server" Text="ºC"></asp:Label></b>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txTemperatura" ErrorMessage="Obrigatório" ValidationGroup="Validar" ForeColor="#FF3300"></asp:RequiredFieldValidator>
            <br />
            <br />
            <b>
                <asp:Label ID="Label8" runat="server" Text="Teor Alcoólico: "></asp:Label></b>
            <asp:TextBox ID="txTeorAlcoolico" runat="server" TextMode="Number"  Width="66px" Min="5"></asp:TextBox>
            <b>
                <asp:Label ID="Label22" runat="server" Text=" %vol"></asp:Label></b>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txTeorAlcoolico" ErrorMessage="Obrigatório" ValidationGroup="Validar" ForeColor="#FF3300"></asp:RequiredFieldValidator>
            <br />
            <br />
            <b>
                <asp:Label ID="Label9" runat="server" Text="Volume: "></asp:Label></b>
            <asp:TextBox ID="txVolume" runat="server" TextMode="Number" Width="86px" min="5" step="1"></asp:TextBox>
            <b>
                <asp:Label ID="Label2" runat="server" Text=" ml"></asp:Label></b>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txVolume" ErrorMessage="Obrigatório" ValidationGroup="Validar" ForeColor="#FF3300"></asp:RequiredFieldValidator>

        </div>
        <div id="conteudo-3" class="auto-style3">

            <asp:Label ID="lbPercentagemTotal" runat="server"></asp:Label>

            <br />
            <asp:Label ID="lbPercentagem" runat="server"></asp:Label>

            <br />

        </div>

        <div id="conteudo-4">
            <hr />
            <div id="conteudo-4-1">

                <b>
                    <asp:Label ID="Label12" runat="server" Text="Castas:"></asp:Label></b><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="lbxxCastas" ErrorMessage="Obrigatório" ValidationGroup="Validar" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                <br />
                <asp:ListBox ID="lbxxCastas" runat="server" Height="220px" Width="250px" SelectionMode="Multiple"></asp:ListBox>


            </div>


            <div id="conteudo-4-2">
                <b>
                    <asp:Label ID="Label11" runat="server" Text="Enologos:"></asp:Label></b><asp:RequiredFieldValidator ID="validarEnologos" runat="server" ControlToValidate="lbxxEnologos" ErrorMessage="Obrigatório" ValidationGroup="Validar" ForeColor="#FF3300"></asp:RequiredFieldValidator><br />
                <asp:ListBox ID="lbxxEnologos" runat="server" Height="220px" SelectionMode="Multiple" Width="250px" ></asp:ListBox>

            </div>

        </div>
        <div class="botao">
        <asp:Button ID="btInserir" runat="server" Height="43px" OnClick="btInserir_Click" Text="Inserir" ValidationGroup="Validar" Width="93px" /></div>
    </div>
</asp:Content>
