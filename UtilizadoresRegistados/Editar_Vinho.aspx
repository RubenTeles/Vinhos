<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Menu.Master" AutoEventWireup="true" CodeBehind="Editar_Vinho.aspx.cs" Inherits="Site_Vinhao.UtilizadoresRegistados.Editar_Vinho" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main_content" runat="server">
    <asp:Label ID="lbTitulo" runat="server" Text="Editar Vinho"></asp:Label>
    <br />
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Nome"></asp:Label>
&nbsp;
    <asp:TextBox ID="txNome" runat="server" Width="400px"></asp:TextBox>
    <br />
    <asp:Label ID="Label1" runat="server" Text="Descrição"></asp:Label>
&nbsp;
    <asp:TextBox ID="txDescricao" runat="server" TextMode="MultiLine" Width="400px"></asp:TextBox>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Produtor"></asp:Label>
&nbsp;
    <asp:DropDownList ID="cbProdutor" runat="server" Width="144px">
    </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label5" runat="server" Text="Ano"></asp:Label>
&nbsp;
    <asp:TextBox ID="txAno" runat="server" TextMode="Number" Width="86px"></asp:TextBox>
    <br />
    <asp:Label ID="Label4" runat="server" Text="Tipo de Vinho"></asp:Label>
&nbsp;
    <asp:DropDownList ID="cbTipo" runat="server" Width="164px">
    </asp:DropDownList>
&nbsp;
    <asp:Label ID="Label6" runat="server" Text="Região"></asp:Label>
&nbsp;<asp:DropDownList ID="cbRegiao" runat="server" Width="136px">
    </asp:DropDownList>
    <br />
    <asp:Label ID="Label7" runat="server" Text="Temperatura"></asp:Label>
    <asp:TextBox ID="txTemperatura" runat="server" Width="86px"></asp:TextBox>
ºC&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label8" runat="server" Text="Teor Alcoólico"></asp:Label>
&nbsp;
    <asp:TextBox ID="txTeorAlcoolico" runat="server" TextMode="Number" Width="66px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label9" runat="server" Text="Volume"></asp:Label>
&nbsp;
    <asp:TextBox ID="txVolume" runat="server" TextMode="Number" Width="86px"></asp:TextBox>
    <br />
    <asp:Label ID="Label10" runat="server" Text="Foto"></asp:Label>
&nbsp;
    <asp:FileUpload ID="uploadFoto" runat="server" />
    <br />
    <asp:Image ID="foto" runat="server" Height="375px" Width="266px" />
    <br />
    <br />
    <asp:Label ID="Label12" runat="server" Text="Castas do Vinho"></asp:Label>
    <br />
    <asp:GridView ID="gridCastasVinho" runat="server" Width="242px">
    </asp:GridView>
    <asp:Button ID="btRemoverCasta" runat="server" Height="32px" Text="Remover Casta" Width="153px" OnClick="btRemoverCasta_Click" />
    <br />
    <br />
    <asp:Label ID="Label11" runat="server" Text="Castas"></asp:Label>
    <asp:GridView ID="gridCastas" runat="server" Width="242px">
    </asp:GridView>
    <asp:TextBox ID="txPercentagem" runat="server" TextMode="Number" placehorder="percentagem da casta"></asp:TextBox>
    <asp:Button ID="btAssociarCasta" runat="server" Height="32px" Text="Associar Casta" Width="153px" OnClick="btAssociarCasta_Click" />
    <br />
    <br />
    <asp:Button ID="btGuardar" runat="server" Height="43px" Text="Guardar" Width="93px" OnClick="btInserir_Click" />
</asp:Content>
