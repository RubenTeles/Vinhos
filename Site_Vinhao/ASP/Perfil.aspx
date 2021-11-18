<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/MasterPage.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="Site_Vinhao.ASP.Perfil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Perfil</title>
    <link href="../CSS/PerfilCSS.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style3 {
            width: 261px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main_content" runat="server">
    <br />

    <br />
    <div id="vinho">
        <div id="imagem" class="auto-style3">
            <asp:Image class="imagem" ID="foto" runat="server" alt="Me" ImageAlign="Middle" Width="280px" />
            <br />
            <asp:ImageButton ID="btEditarImagem" runat="server" Height="25px" Width="25px" ImageUrl="~/Imagens/Conteudo/settings.png" Visible="False" OnClick="btEditarImagem_Click" ValidationGroup="ValidarFoto" />
            <asp:ImageButton ID="btCruzFoto" runat="server" Height="25px" ImageUrl="~/Imagens/Conteudo/cruz.png" OnClick="btCruzFoto_Click" Visible="False" Width="25px" />
            <b>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="updateFoto" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True" ValidationGroup="ValidarFoto"></asp:RequiredFieldValidator>
            </b>
            <asp:FileUpload ID="updateFoto" runat="server" Visible="False" />
            <br />
            <b>
                <asp:Label ID="Label29" runat="server" Text="Nasceu: "></asp:Label></b><asp:Label ID="lbDataNascimento" runat="server"></asp:Label>
            <asp:ImageButton ID="btEditarDataNascimento" runat="server" Height="25px" Width="25px" ImageUrl="~/Imagens/Conteudo/settings.png" Visible="False" OnClick="btEditarDataNascimento_Click" ValidationGroup="ValidarNascimento" />
            <asp:ImageButton ID="btCruzDataNascimento" runat="server" Height="25px" ImageUrl="~/Imagens/Conteudo/cruz.png" OnClick="btCruzDataNascimento_Click" Visible="False" Width="25px" />
            <br />
            <asp:TextBox ID="txDatadeNascimento" runat="server" TextMode="Date" Visible="false" Enabled="false"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txDatadeNascimento" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True" ValidationGroup="ValidarNascimento"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="validarDataNascimento" runat="server" ControlToValidate="txDatadeNascimento" ErrorMessage="*" ForeColor="#FF3300" ValidationGroup="ValidarNascimento"></asp:CompareValidator>
            <br />
            <b>
                <asp:Label ID="Label5" runat="server" Text="Email: " Visible="False"></asp:Label></b><asp:Label ID="lbEmail" runat="server" Visible="False"></asp:Label>
            <asp:ImageButton ID="btEditarEmail" runat="server" Height="25px" Width="25px" ImageUrl="~/Imagens/Conteudo/settings.png" Visible="False" OnClick="btEditarEmail_Click" ValidationGroup="ValidarEmail" />
            <asp:ImageButton ID="btCruzEmail" runat="server" Height="25px" ImageUrl="~/Imagens/Conteudo/cruz.png" OnClick="btCruzEmail_Click" Visible="False" Width="25px" />
            <br />
            <asp:TextBox ID="txEmail" runat="server" TextMode="Email" Visible="false" Enabled="false"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txEmail" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True" ValidationGroup="ValidarEmail"></asp:RequiredFieldValidator>
        </div>

        <div id="conteudo-1">
            <div id="conteudo-1-1">
                <b>
                    <asp:Label ID="lbNomeUtilizador" runat="server" Font-Italic="False" Font-Size="Large"></asp:Label></b>&nbsp;<asp:TextBox ID="txNome" runat="server" Visible="false"></asp:TextBox><b>
                        <asp:ImageButton ID="btEditar" runat="server" Height="25px" Width="25px" ImageUrl="~/Imagens/Conteudo/settings.png" Visible="False" OnClick="btEditar_Click" ValidationGroup="validarNome" />
                        <asp:ImageButton ID="btCruzNome" runat="server" Height="25px" ImageUrl="~/Imagens/Conteudo/cruz.png" Visible="False" Width="25px" OnClick="btCruzNome_Click" />


                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txNome" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True" ValidationGroup="validarNome"></asp:RequiredFieldValidator>
                    </b>
                <br />
            </div>
            <div id="conteudo-1-2">
                <div id="conteudo-1-2-1">
                    <hr />
                    <b>
                        <asp:Label ID="Label25" runat="server" Text="Criado: "></asp:Label></b><asp:Label ID="lbCriado" runat="server"></asp:Label>
                </div>
                <div id="conteudo-1-2-2">
                    <hr />
                    <b>
                        <asp:Label ID="Label26" runat="server" Text="Ultima Entrada: "></asp:Label></b><asp:Label ID="lbUltimaEntrada" runat="server"></asp:Label>
                </div>
            </div>
            <div id="conteudo-1-3">
                <hr />
                <b>
                    <asp:Label ID="Label1" runat="server" Text="Descrição: "></asp:Label>
                    <asp:ImageButton ID="btEditarDescricao" runat="server" Height="25px" Width="25px" ImageUrl="~/Imagens/Conteudo/settings.png" Visible="False" OnClick="btEditarDescricao_Click" ValidationGroup="ValidarDescricao" />
                    <asp:ImageButton ID="btCruzDescricao" runat="server" Height="25px" ImageUrl="~/Imagens/Conteudo/cruz.png" OnClick="btCruzDescricao_Click" Visible="False" Width="25px" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtDescricao" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True" ValidationGroup="ValidarDescricao"></asp:RequiredFieldValidator>
                </b>
                <br />
                <asp:TextBox ID="txtDescricao" runat="server" Height="100px" TextMode="MultiLine" Visible="false" Enabled="false" Width="635px"></asp:TextBox>
                <asp:Label ID="lbDescricao" runat="server"></asp:Label><br />
            </div>
        </div>
        <div id="conteudo-2-2">
            <hr />
            <b>
                <asp:Label ID="Label4" runat="server" Text="Dados:" Font-Size="Large"></asp:Label></b>
            <br />
            <br />
            <b>
                <asp:Label ID="Label6" runat="server" Text="Comentou: "></asp:Label></b><asp:Label ID="lbnumeroComentarios" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            <b>
                <asp:Label ID="Label3" runat="server" Text="Classificou: "></asp:Label></b><asp:Label ID="lbnumeroClassificados" runat="server"></asp:Label>

            <br />

            <br />
            <asp:GridView ID="gridPerfil" runat="server" OnRowDataBound="gridPerfil_RowDataBound" ShowHeader="False" Visible="False">
            </asp:GridView>

        </div>

        <div id="conteudo-2-1">
            <hr />
            <b>
                <asp:ChangePassword ID="MudarPassword" runat="server" CancelButtonText="Cancelar" ChangePasswordButtonText="Mudar Password" ChangePasswordFailureText="Senha incorreta ou Nova senha inválida. Comprimento mínimo da nova senha: {0}. Caracteres não alfanuméricos cultivados: {1}." ChangePasswordTitleText="Mude a sua Password" ConfirmNewPasswordLabelText="Confirmar a sua nova Password" ConfirmPasswordCompareErrorMessage="A confirmação da nova password deve corresponder à entrada da nova password." ConfirmPasswordRequiredErrorMessage="É necessário confirmar a nova password." ContinueButtonText="Continuar" NewPasswordLabelText="Nova Password:" NewPasswordRegularExpressionErrorMessage="Por favor insira uma password diferente." NewPasswordRequiredErrorMessage="É necessária uma nova password." PasswordRequiredErrorMessage="É necessária uma Password." SuccessText="Sua Password foi mudada!" SuccessTitleText="
Mudança de password completa"
                    UserNameLabelText="UserName:" UserNameRequiredErrorMessage="UserName é requerido." Visible="False">
                </asp:ChangePassword>

                <br />
            </b>
            <br />
            <br />
            <br />
            <br />

        </div>


        <div id="conteudo-4">
            <hr />
            <div id="conteudo-3">
                <div id="vinhos_por_aprovar" runat="server" visible="false">
                    <b>
                        <asp:Label ID="Label7" runat="server" Text="Por Aprovar: "></asp:Label></b>(<asp:Label ID="lbnumeroPorAprovar" runat="server"></asp:Label>)
        
        <asp:Repeater ID="Repeater3" runat="server">
            <ItemTemplate>
                <div class="procurar">
                    <table class="auto-style5">
                        <td class="auto-style4">
                            <asp:Image ID="Image1" runat="server" Height="85px" ImageUrl='<%#Eval("Foto") %>' />
                        </td>
                        <td class="auto-style3"><a href="../UtilizadoresRegistados/EditarVinho.aspx?vinho=<%#Eval("VinhoID") %>">
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

            </div>
            <div id="conteudo-4-1">

                <b>
                    <asp:Label ID="Label12" runat="server" Text="Os Seus Vinhos: "></asp:Label></b>(<asp:Label ID="lbnumeroVinhos" runat="server"></asp:Label>)
                
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <div class="procurar1">
                            <table class="auto-style5">
                                <td class="auto-style4">
                                    <a href="../ASP/Vinho.aspx?vinho=<%#Eval("VinhoID")%>">
                                        <asp:Image ID="Image1" runat="server" Height="85px" ImageUrl='<%#Eval("Foto") %>' /></a>
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


            <div id="conteudo-4-2">
                <b>
                    <asp:Label ID="Label11" runat="server" Text="Vinhos Favoritos: "></asp:Label></b>(<asp:Label ID="lbnumeroFavoritos" runat="server"></asp:Label>)
                <br />
                <asp:Repeater ID="Repeater2" runat="server">
                    <ItemTemplate>
                        <div class="procurar2">
                            <table class="auto-style5">
                                <td class="auto-style4">
                                    <a href="../ASP/Vinho.aspx?vinho=<%#Eval("VinhoID")%>">
                                        <asp:Image ID="Image1" runat="server" Height="85px" Width="60px" ImageUrl='<%#Eval("Foto") %>' /></a>
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

        </div>
    </div>
    <br />
    <br />
    <br />
    <br />
</asp:Content>
