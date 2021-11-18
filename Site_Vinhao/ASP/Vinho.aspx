<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/MasterPage.Master" AutoEventWireup="true" CodeBehind="Vinho.aspx.cs" Inherits="Site_Vinhao.ASP.Vinho" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Vinho</title>
    <link href="../CSS/VinhoCSS.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style3 {
            width: 261px;
        }
        .auto-style4 {
            height: 29px;
        }
        .auto-style5 {
            width: 221px;
            height: 29px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main_content" runat="server">
    <br />

    <br />
    <div id="vinho">
        <div id="imagem" class="auto-style3">
            <asp:Image class="imagem" ID="foto" runat="server" alt="Me" ImageAlign="Middle" Height="350px" maxHeight="320" />
            <br />
            <br />
            <div id="Classificacao" runat="server">
                <asp:Label ID="Label5" runat="server" Text="Classifique:" Font-Bold="True"></asp:Label>
                <br />
                <asp:ImageButton ID="estrela1" runat="server" Height="40px" Width="40px" OnClick="estrela1_Click" />
                <asp:ImageButton ID="estrela2" runat="server" Height="40px" Width="40px" OnClick="estrela2_Click" />
                <asp:ImageButton ID="estrela3" runat="server" Height="40px" Width="40px" OnClick="estrela3_Click" />
                <asp:ImageButton ID="estrela4" runat="server" Height="40px" Width="40px" OnClick="estrela4_Click" />
                <asp:ImageButton ID="estrela5" runat="server" Height="40px" Width="40px" OnClick="estrela5_Click" />
            </div>
            <br />
            <br />
            <br />
            <br /> _
        </div>

        <div id="conteudo-1">
            <div id="conteudo-1-1">
                <b>
                    <asp:Label ID="txNome" runat="server" Font-Italic="False" Font-Size="Large"></asp:Label></b>
                <asp:ImageButton ID="imgFavorito" runat="server" Height="15px" OnClick="imgFavorito_Click" Width="15px" />
            </div>
            <div id="conteudo-1-2">
                <div id="conteudo-1-2-1">
                    <hr />
                    <b>
                        <asp:Label ID="Label25" runat="server" Text="Postado por: "></asp:Label></b><asp:Label ID="txNomeUtilizador" runat="server"></asp:Label>
                </div>
                <div id="conteudo-1-2-2">
                    <hr />
                    <b>
                        <asp:Label ID="Label26" runat="server" Text="Classificação: "></asp:Label></b><asp:Label ID="lbClassificacao" runat="server"></asp:Label>
                </div>
            </div>
            <div id="conteudo-1-3">
                <hr />
                <b>
                    <asp:Label ID="Label1" runat="server" Text="Descrição: "></asp:Label></b>
                <br />
                <asp:Label ID="txDescricao" runat="server"></asp:Label><br />
            </div>
        </div>
        <div id="conteudo-2-2">
            <hr />
            <b>
                <asp:Label ID="Label4" runat="server" Text="Tipo de Vinho: "></asp:Label></b><asp:Label ID="cbTipo" runat="server"></asp:Label>
            <br />
            <br />
            <b>
                <asp:Label ID="Label10" runat="server" Text="Ano: "></asp:Label></b><asp:Label ID="txAno" runat="server"></asp:Label>
            <br />
            <br />
            <b>
                <asp:Label ID="Label6" runat="server" Text="Região: "></asp:Label></b><asp:Label ID="cbRegiao" runat="server"></asp:Label>
            <br />
            <br />
            <b>
                <asp:Label ID="Label3" runat="server" Text="Produtor: "></asp:Label></b><asp:Label ID="cbProdutor" runat="server"></asp:Label>

        </div>

        <div id="conteudo-2-1">
            <hr />
            <b>
                <asp:Label ID="Label7" runat="server" Text="Temperatura: "></asp:Label></b>
            <asp:Label ID="txTemperatura" runat="server"></asp:Label><asp:Label ID="Label24" runat="server" Text="ºC"></asp:Label>
            <br />
            <br />
            <b>
                <asp:Label ID="Label8" runat="server" Text="Teor Alcoólico: "></asp:Label></b><asp:Label ID="txTeorAlcoolico" runat="server"></asp:Label><asp:Label ID="Label22" runat="server" Text=" %vol"></asp:Label>
            <br />
            <br />
            <b>
                <asp:Label ID="Label9" runat="server" Text="Volume: "></asp:Label></b>
            <asp:Label ID="txVolume" runat="server"></asp:Label><asp:Label ID="Label23" runat="server" Text="vol"></asp:Label>

        </div>
        <div id="conteudo-3">
            <asp:GridView ID="gridCastasVinho" runat="server" OnRowDataBound="gridCastasVinho_RowDataBound" ShowHeader="False" Visible="False">
            </asp:GridView>
            <br />
            <br />

        </div>

        <div id="conteudo-4">
            <hr />
            <div id="conteudo-4-1">

                <b>
                    <asp:Label ID="Label12" runat="server" Text="Castas:"></asp:Label></b>
                <asp:Repeater ID="RepeaterCasta" runat="server">
                    <ItemTemplate>
                        <div class="casta">

                            <%--<b> NEGRITO </b> --%><asp:Label ID="Label1" runat="server" Text='<%#Eval("Percentagem") %>'></asp:Label>%&nbsp;<asp:Label ID="Label2" runat="server" Text='<%#Eval("NomeCasta") %>'></asp:Label>

                            <br />
                        </div>
                    </ItemTemplate>
                </asp:Repeater>

            </div>


            <div id="conteudo-4-2">
                <b>
                    <asp:Label ID="Label11" runat="server" Text="Enologos:"></asp:Label></b><br />
                <asp:Repeater ID="RepeaterEnologo" runat="server">
                    <ItemTemplate>
                        <div class="enologo">

                            <asp:Label ID="Label1" runat="server" Text='<%#Eval("NomeEnologo") %>'></asp:Label>

                            <br />
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
                <%--<b> NEGRITO </b> --%>
            </div>

        </div>
    </div>

    <br />

    <br />
    <br />
    _
    <hr />
    <h4 style="text-decoration: underline;">Comentários:</h4>
    <div id="comentario">
        <div class="formDesign" runat="server" id="fazercomentario">
            <table>
                <tr>
                    <td class="auto-style1">Nome</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txNomeComentario" runat="server" Width="208px" ReadOnly="True" BackColor="#CCCCCC"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txNomeComentario" ErrorMessage="Escreva um Nome" ForeColor="#CC0000" ValidationGroup="validar">Escreva um Nome</asp:RequiredFieldValidator>
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
    </div>
    <br />
    <hr />
    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
            <b>
                <a href="Perfil.aspx?utilizador=<%#Eval("UtilizadorID") %>">
                    <asp:Label ID="Label1" runat="server" Text='<%#Eval("Nome") %>'>'></asp:Label></a></b>
            <br />
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
                    runat="server" ForeColor="White" Font-Bold="True" CausesValidation="false"><%# Container.DataItem %></asp:LinkButton>
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
