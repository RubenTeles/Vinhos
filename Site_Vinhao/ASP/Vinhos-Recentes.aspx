<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/MasterPage.Master" AutoEventWireup="true" CodeBehind="Vinhos-Recentes.aspx.cs" Inherits="Site_Vinhao.ASP.Vinhos_Recentes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Vinhos Recentes</title>
    <link href="../CSS/TopVinhosCSS.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main_content" runat="server">
    <div class="esquerdaa">
        <asp:Label ID="lbTitulo" runat="server" Font-Bold="True" Font-Size="X-Large">Vinhos Recentes</asp:Label><br />
        <asp:Label ID="lbSubTitulo" runat="server" Text="Os últimos Vinhos Postados" Font-Bold="True" Font-Italic="True" Font-Size="Medium"></asp:Label>
        <br />
        <br />
    </div>
    <div class="main">
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <div class="tablee">
                    <hr />
                    <table class="auto-style5">
                        <td class="auto-style4">
                            <asp:Image ID="Image1" runat="server" ImageUrl='<%#Eval("Foto") %>' Width="120px" />
                        </td>
                        <td class="auto-style3"><a href="Vinho.aspx?vinho=<%#Eval("VinhoID") %>">
                            <asp:Label ID="Label4" runat="server" Text='<%#Eval("NomeVinho") %>'></asp:Label>&nbsp;(<asp:Label ID="Label22" runat="server" Text='<%#Eval("Ano") %>'></asp:Label>):</a><br />

                            <asp:Label ID="Label5" runat="server" Text="Postado por: "></asp:Label><a href="Perfil.aspx?utilizador=<%#Eval("UtilizadorID") %>"><asp:Label ID="Label3" runat="server" Text='<%#Eval("Utilizador") %>'></asp:Label></a><br />

                            <asp:Label ID="Label2" runat="server" Text='<%#Eval("DataDePublicacao") %>'></asp:Label>

                        </td>
                    </table>
                </div>
                <br />
                <br />
            </ItemTemplate>
</asp:Repeater>

            
        <div class="pagina">
            <br />
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
    </div>
</asp:Content>
