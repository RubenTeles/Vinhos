<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Menu.Master" AutoEventWireup="true" CodeBehind="Procurar.aspx.cs" Inherits="Site_Vinhao.ASP.Procurar" %>

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
    <asp:TextBox ID="txProcurar" runat="server" TextMode="Search"></asp:TextBox>
    <asp:Button ID="btProcurar" runat="server" OnClick="btProcurar_Click" Text="   " ValidationGroup="Validar" />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txProcurar" ErrorMessage="RequiredFieldValidator" ValidationGroup="Validar"></asp:RequiredFieldValidator>
    <br />
    <br />
    <%--<asp:GridView ID="gridProcurar" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="gridProcurar_SelectedIndexChanged" ShowHeader="False" Visible="False" OnRowDataBound="gridProcurar_RowDataBound">
    </asp:GridView>--%>




    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
            <div class="procurar">
                <table class="auto-style5">
                    <td class="auto-style4"><asp:Image ID="Image1" runat="server" Height="85px" Width="60px" ImageUrl='<%#Eval("Foto") %>' />
                        </td>
                    <td class="auto-style3"><a href="Vinho.aspx?vinho=<%#Eval("VinhoID") %>">
                            <asp:Label ID="Label4" runat="server" Text='<%#Eval("NomeVinho") %>'></asp:Label>&nbsp;(<asp:Label ID="Label2" runat="server" Text='<%#Eval("Ano") %>'></asp:Label>):</a><br />

                        <asp:Label ID="Label3" runat="server" Text='<%#Eval("Descricao") %>'></asp:Label><br />

                    </td>
                </table>
            </div>
        </ItemTemplate>
    </asp:Repeater>
    <asp:Repeater ID="rptPaging" runat="server" OnItemCommand="rptPaging_ItemCommand">
        <ItemTemplate>
            <asp:LinkButton ID="btnPage"
                Style="padding: 8px; margin: 2px; background: #007acc; border: solid 1px blue; font: 8px;"
                CommandName="Page" CommandArgument="<%# Container.DataItem %>"
                runat="server" ForeColor="White" Font-Bold="True" CausesValidation="false"><%# Container.DataItem %>
            </asp:LinkButton>
        </ItemTemplate>
    </asp:Repeater>

</asp:Content>
