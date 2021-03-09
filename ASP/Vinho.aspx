<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Menu.Master" AutoEventWireup="true" CodeBehind="Vinho.aspx.cs" Inherits="Site_Vinhao.ASP.Vinho" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Vinho</title>
    <link href="../CSS/VinhoCSS.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main_content" runat="server">
    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Nome: "></asp:Label>
    &nbsp;
    <asp:Label ID="txNome" runat="server"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label25" runat="server" Text="Utilizador: "></asp:Label>
    <asp:Label ID="txUtilizador" runat="server"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label26" runat="server" Text="Classificação: "></asp:Label>
    <asp:Label ID="lbClassificacao" runat="server"></asp:Label>
    <br />
    <asp:Image ID="foto" runat="server" Height="300px" ImageAlign="Middle" Width="200px" />
    <asp:Label ID="Label1" runat="server" Text="Descrição: "></asp:Label>
    <asp:Label ID="txDescricao" runat="server"></asp:Label>
    <br />
    &nbsp;
    <asp:Button ID="btFavorito" runat="server" OnClick="btFavorito_Click" Width="283px" />

    &nbsp;<br />
    <asp:Label ID="Label3" runat="server" Text="Produtor: "></asp:Label>
    <asp:Label ID="cbProdutor" runat="server"></asp:Label>
    &nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label5" runat="server" Text="Ano: "></asp:Label>
    <asp:Label ID="txAno" runat="server"></asp:Label>
    <br />


    <asp:Label ID="Label4" runat="server" Text="Tipo de Vinho: "></asp:Label>
    <asp:Label ID="cbTipo" runat="server"></asp:Label>
    &nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label6" runat="server" Text="Região: "></asp:Label>
    <asp:Label ID="cbRegiao" runat="server"></asp:Label>
    <br />
    <asp:Label ID="Label7" runat="server" Text="Temperatura: "></asp:Label>
    <asp:Label ID="txTemperatura" runat="server"></asp:Label>
    <asp:Label ID="Label24" runat="server" Text="ºC"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label8" runat="server" Text="Teor Alcoólico: "></asp:Label>
    <asp:Label ID="txTeorAlcoolico" runat="server"></asp:Label>
    <asp:Label ID="Label22" runat="server" Text=" %vol"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label9" runat="server" Text="Volume: "></asp:Label>
    <asp:Label ID="txVolume" runat="server"></asp:Label>
    <asp:Label ID="Label23" runat="server" Text="vol"></asp:Label>
    &nbsp;
    <br />
    &nbsp;
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
    <br />
    &nbsp;<asp:Label ID="Label12" runat="server" Text="Castas"></asp:Label>
    <asp:GridView ID="gridCastasVinho" runat="server" OnRowDataBound="gridCastasVinho_RowDataBound" ShowHeader="False">
    </asp:GridView>
    <br />
    <br />
    <asp:Label ID="Label11" runat="server" Text="Enologos"></asp:Label>
    <asp:GridView ID="gridEnologosVinho" runat="server" OnRowDataBound="gridEnologosVinho_RowDataBound" ShowHeader="False">
    </asp:GridView>
    <br />
    <br />
    <hr />
    <div class="formDesign" runat="server" id="fazercomentario">
        <table style="width: 100%;">
            <tr>
                <td class="auto-style1">Nome</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txNomeComentario" runat="server" Width="208px" ReadOnly="True"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txNomeComentario" ErrorMessage="Escreva um Nome" ForeColor="#CC0000" ValidationGroup="validar">Escreva um Nome</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Classificação</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txClassificacao" runat="server" Width="206px" TextMode="Number"></asp:TextBox>
                </td>
                <td>

                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txClassificacao" ErrorMessage="*" ForeColor="#CC0000" ValidationGroup="validar" SetFocusOnError="True">*</asp:RequiredFieldValidator>

                    <asp:RangeValidator ID="Range1" ControlToValidate="txClassificacao" MinimumValue="1" MaximumValue="5" Type="Integer" ErrorMessage="Escreva um valor entre 1 e 5!" ForeColor="#CC0000" Text="Escreva um valor entre 1 e 5!" runat="server" ValidationGroup="validar" />

                </td>
            </tr>
            <tr>
                <td class="auto-style1">Comentário</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txComentario" runat="server" Height="44px" TextMode="MultiLine" Width="211px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txComentario" ErrorMessage="Escreva um Comentário!" ForeColor="#CC0000" ValidationGroup="validar">Escreva um Comentário!</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Button ID="btPostar" runat="server" Text="Postar Comentário" OnClick="btPostar_Click" CssClass="buttonSubmit" Width="211px" ValidationGroup="validar" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </div>
    <h4 style="text-decoration: underline;">Comentários:</h4>
    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
            <div class="commentbox">
                <b>

                    <%--<a href="Perfil.aspx?id=<%#Eval("VinhoID") %>"  >--%><asp:Label ID="Label1" runat="server" Text='<%#Eval("Nome") %>'>'></asp:Label><%--</a>--%></b>&nbsp;(<asp:Label ID="Label2" runat="server" Text='<%#Eval("Classificacao") %>'>'></asp:Label>☆):<br />
                <asp:Label ID="Label3" runat="server" Text='<%#Eval("Comentario") %>'></asp:Label><br />
                <br />
            </div>
        </ItemTemplate>
    </asp:Repeater>
    <div style="overflow: hidden;">
        <asp:Repeater ID="rptPaging" runat="server" OnItemCommand="rptPaging_ItemCommand">
            <ItemTemplate>
                <asp:LinkButton ID="btnPage"
                    Style="padding: 8px; margin: 2px; background: #007acc; border: solid 1px blue; font: 8px;"
                    CommandName="Page" CommandArgument="<%# Container.DataItem %>"
                    runat="server" ForeColor="White" Font-Bold="True" CausesValidation="false"><%# Container.DataItem %>
                </asp:LinkButton>
            </ItemTemplate>
        </asp:Repeater>
    </div>

    <br />
    <br />
    <br />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;
    <br />
    <br />
</asp:Content>
