<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/MasterPage.Master" AutoEventWireup="true" CodeBehind="Procurar.aspx.cs" Inherits="Site_Vinhao.ASP.Procurar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            height: 115px;
        }

        .auto-style4 {
            height: 115px;
            width: 69px;
        }

        .auto-style5 {
            width: 55%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main_content" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Procurar: "></asp:Label>
    <asp:DropDownList ID="cbCategorias" runat="server" OnSelectedIndexChanged="cbCategorias_SelectedIndexChanged" OnTextChanged="cbCategorias_TextChanged" AutoPostBack="True">
        <asp:ListItem Selected="True" Value="0">Vinho</asp:ListItem>
        <asp:ListItem Value="1">Utilizador</asp:ListItem>
        <asp:ListItem Value="2">Região</asp:ListItem>
        <asp:ListItem Value="3">Casta</asp:ListItem>
        <asp:ListItem Value="4">Enologo</asp:ListItem>
        <asp:ListItem Value="5">Produtor</asp:ListItem>
        <asp:ListItem Value="6">Tipo de Vinho</asp:ListItem>
    </asp:DropDownList>
    <asp:TextBox ID="txProcurar" runat="server" TextMode="Search" ValidationGroup="Validar"></asp:TextBox>
    <asp:DropDownList ID="cbRegiao" runat="server" Enabled="False" Visible="False" ValidationGroup="Validar" ClientIDMode="Static"></asp:DropDownList>
    <asp:DropDownList ID="cbCasta" runat="server" Enabled="False" Visible="False" ValidationGroup="Validar"></asp:DropDownList>
    <asp:DropDownList ID="cbEnologo" runat="server" Enabled="False" Visible="False" ValidationGroup="Validar"></asp:DropDownList>
    <asp:DropDownList ID="cbProdutor" runat="server" Enabled="False" Visible="False" ValidationGroup="Validar"></asp:DropDownList>
    <asp:DropDownList ID="cbTipo" runat="server" Enabled="False" Visible="False" ValidationGroup="Validar"></asp:DropDownList>
    
    <asp:ImageButton ID="btProcurarImg" runat="server" ImageUrl="~/Imagens/Conteudo/lupa.png" OnClick="ImageButton1_Click" ValidationGroup="Validar" Width="15px" Height="15px" />
        
    <asp:ImageButton ID="btProcurarImg2" runat="server" ImageUrl="~/Imagens/Conteudo/lupa.png" OnClick="btProcurarImg2_Click" Width="15px" Height="15px" Enabled="False" Visible="False" />
    
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txProcurar" ErrorMessage="*" ValidationGroup="Validar" ForeColor="#FF3300"></asp:RequiredFieldValidator>
    <br />
    <br />




    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
            <div class="procurar">
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
</asp:Content>
