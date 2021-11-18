<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/MasterPage.Master" AutoEventWireup="true" CodeBehind="TopVinhos.aspx.cs" Inherits="Site_Vinhao.ASP.TopVinhos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../CSS/TopVinhosCSS.css" rel="stylesheet" />
    <title>Top 10 Vinhos</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main_content" runat="server">

    <div class="top-10"></div>

    <div class="esquerdaa">
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large">☆ Top 5 ☆</asp:Label><br />
        <asp:Label ID="Label2" runat="server" Text="Vinhos mais Classificados" Font-Bold="True" Font-Italic="True" Font-Size="Medium"></asp:Label>
    </div>

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

                            <asp:Label ID="Label5" runat="server" Text="Postado por: "></asp:Label><a href="Perfil.aspx?utilizador=<%#Eval("uID") %>"><asp:Label ID="Label3" runat="server" Text='<%#Eval("Utilizador") %>'></asp:Label></a><br />

                            <br /><asp:Label ID="Classificacao" runat="server" Text='<%# Eval("Classificacao") %>'></asp:Label>&nbsp;☆<br /><br />

                            <asp:Label ID="Label2" runat="server" Text='<%#Eval("DataDePublicacao") %>'></asp:Label>

                        </td>
                    </table>
                </div>
                <br />
                <br />
            </ItemTemplate>
</asp:Repeater>



  <%--  <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>

            <div class="tablee">
                <div class="imagemm">

                    <asp:Image ID="Image1" runat="server" Height="338px" ImageUrl='<%#Eval("Foto") %>' />
                </div>
                <div class="tituloo">
                    <a href="../ASP/Vinho.aspx?vinho=<%#Eval("VinhoID") %>">
                        <asp:Label ID="Nome" runat="server" Text='<%# Eval("NomeVinho") %>'></asp:Label>&nbsp;(<asp:Label ID="Classificacao" runat="server" Text='<%# Eval("Classificacao") %>'></asp:Label>&nbsp;☆)</a><br />
                <br />
                <br /><br />
                <br /><br />
                <br />
                <br /><br />
                <br />
                </div>

            </div>
        </ItemTemplate>

    </asp:Repeater>--%>



</asp:Content>
