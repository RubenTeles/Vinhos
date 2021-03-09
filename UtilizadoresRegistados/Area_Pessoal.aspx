<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Menu.Master" AutoEventWireup="true" CodeBehind="Area_Pessoal.aspx.cs" Inherits="Site_Vinhao.UtilizadoresRegistados.Area_Pessoal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Área Pessoal</title>
    <link href="../CSS/AreaPessoalCSS.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main_content" runat="server">
    <br />
    <asp:Label ID="Label1" runat="server" Text="Bem Vindo "></asp:Label><asp:Label ID="lbNome" runat="server" Text='<%#Eval("NomeVinho") %>'></asp:Label>!
    <br />
    <br />
    <div id="os-seus-vinhos">
        Os seus Vinhos:<br />
        <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
            <ItemTemplate>
                <div class="procurar1">
                    <table class="auto-style5">
                        <td class="auto-style4">
                            <asp:Image ID="Image1" runat="server" Height="85px" Width="60px" ImageUrl='<%#Eval("Foto") %>' />
                        </td>
                        <td class="auto-style3"><a href="../ASP/Vinho.aspx?vinho=<%#Eval("VinhoID") %>">
                            <asp:Label ID="Label4" runat="server" Text='<%#Eval("NomeVinho") %>'></asp:Label><br />
                            (<asp:Label ID="Label2" runat="server" Text='<%#Eval("Ano") %>'></asp:Label>)</a>


                        </td>
                    </table>
                </div>
            </ItemTemplate>
        </asp:Repeater>
        <asp:Repeater ID="rptPaging1" runat="server" OnItemCommand="rptPaging1_ItemCommand">
            <ItemTemplate>
                <asp:LinkButton ID="btnPage1"
                    Style="padding: 8px; margin: 2px; background: #007acc; border: solid 1px blue; font: 8px;"
                    CommandName="Page" CommandArgument="<%# Container.DataItem %>"
                    runat="server" ForeColor="White" Font-Bold="True" CausesValidation="false"><%# Container.DataItem %>
                </asp:LinkButton>
            </ItemTemplate>
        </asp:Repeater>
    </div>


    <div id="vinhos-favoritos">
        Os seus Vinhos Favoritos
        <asp:Repeater ID="Repeater2" runat="server" OnItemCommand="Repeater2_ItemCommand">
            <ItemTemplate>
                <div class="procurar2">
                    <table class="auto-style5">
                        <td class="auto-style4">
                            <asp:Image ID="Image1" runat="server" Height="85px" Width="60px" ImageUrl='<%#Eval("Foto") %>' />
                        </td>
                        <td class="auto-style3"><a href="../ASP/Vinho.aspx?vinho=<%#Eval("VinhoID")%>">
                            <asp:Label ID="Label4" runat="server" Text='<%#Eval("NomeVinho") %>'></asp:Label><br />
                            (<asp:Label ID="Label2" runat="server" Text='<%#Eval("Ano") %>'></asp:Label>)</a>


                        </td>
                    </table>
                </div>
            </ItemTemplate>
        </asp:Repeater>
        <asp:Repeater ID="rptPaging2" runat="server" OnItemCommand="rptPaging2_ItemCommand">
            <ItemTemplate>
                <asp:LinkButton ID="btnPage2"
                    Style="padding: 8px; margin: 2px; background: #007acc; border: solid 1px blue; font: 8px;"
                    CommandName="Page" CommandArgument="<%# Container.DataItem %>"
                    runat="server" ForeColor="White" Font-Bold="True" CausesValidation="false"><%# Container.DataItem %>
                </asp:LinkButton>
            </ItemTemplate>
        </asp:Repeater>


    </div>



    <div id="vinhos-por-aprovar">
        Os seus Vinhos por Aprovar:
        <asp:Repeater ID="Repeater3" runat="server" OnItemCommand="Repeater3_ItemCommand">
            <ItemTemplate>
                <div class="procurar">
                    <table class="auto-style5">
                        <td class="auto-style4">
                            <asp:Image ID="Image1" runat="server" Height="85px" Width="60px" ImageUrl='<%#Eval("Foto") %>' />
                        </td>
                        <td class="auto-style3"><a href="../ASP/Vinho.aspx?vinho=<%#Eval("VinhoID") %>">
                            <asp:Label ID="Label4" runat="server" Text='<%#Eval("NomeVinho") %>'></asp:Label><br />
                            (<asp:Label ID="Label2" runat="server" Text='<%#Eval("Ano") %>'></asp:Label>)</a>


                        </td>
                    </table>
                </div>
            </ItemTemplate>
        </asp:Repeater>
        <asp:Repeater ID="rptPaging3" runat="server" OnItemCommand="rptPaging3_ItemCommand">
            <ItemTemplate>
                <asp:LinkButton ID="btnPage3"
                    Style="padding: 8px; margin: 2px; background: #007acc; border: solid 1px blue; font: 8px;"
                    CommandName="Page" CommandArgument="<%# Container.DataItem %>"
                    runat="server" ForeColor="White" Font-Bold="True" CausesValidation="false"><%# Container.DataItem %>
                </asp:LinkButton>
            </ItemTemplate>
        </asp:Repeater>

    </div>


</asp:Content>
