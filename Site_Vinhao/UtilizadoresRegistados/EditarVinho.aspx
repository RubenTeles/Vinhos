<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/MasterPage.Master" AutoEventWireup="true" CodeBehind="EditarVinho.aspx.cs" Inherits="Site_Vinhao.UtilizadoresRegistados.EditarVinho" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Editar Vinho</title>
    <link href="../CSS/VinhoCSS.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main_content" runat="server">


    <div id="vinho">
        <div id="imagem" class="auto-style3">
            <asp:Image class="imagem" ID="foto" runat="server" alt="Me" ImageAlign="Middle" Height="350px" maxHeight="320" />
            <br />
            <asp:ImageButton ID="btEditarImagem" runat="server" Height="25px" Width="25px" ImageUrl="~/Imagens/Conteudo/settings.png" OnClick="btEditarImagem_Click" ValidationGroup="ValidarFoto" />
            <asp:ImageButton ID="btCruzFoto" runat="server" Height="25px" ImageUrl="~/Imagens/Conteudo/cruz.png" Visible="False" Width="25px" OnClick="btCruzFoto_Click" />
            <b>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="updateFoto" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True" ValidationGroup="ValidarFoto"></asp:RequiredFieldValidator>
            </b>
            <asp:FileUpload ID="updateFoto" runat="server" Visible="False" />

            <br />

            <br />
            <asp:Label ID="lbVinhoID" runat="server" Text="" Visible="false"></asp:Label>
            <br />
            <asp:Label ID="lbPercentagem" runat="server" Text="" Visible="false"></asp:Label>
            <br />
            <br />
            _
        </div>

        <div id="conteudo-1">
            <div id="conteudo-1-1">
                <b>
                    <asp:Label ID="lbNomeVinho" runat="server" Font-Italic="False" Font-Size="Large"></asp:Label></b>&nbsp;
                <asp:TextBox ID="txNomeVinho" runat="server" Visible="false" Enabled="false"></asp:TextBox>
                <asp:ImageButton ID="btEditarNomeVinho" runat="server" Height="25px" Width="25px" ImageUrl="~/Imagens/Conteudo/settings.png" ValidationGroup="validarNome" OnClick="btEditarNomeVinho_Click" />
                <asp:ImageButton ID="btCruzNomeVinho" runat="server" Height="25px" ImageUrl="~/Imagens/Conteudo/cruz.png" Visible="False" Width="25px" OnClick="btCruzNomeVinho_Click" />
                <b>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txNomeVinho" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True" ValidationGroup="validarNome"></asp:RequiredFieldValidator>
                </b>
                <br />
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
                        <asp:Label ID="Label26" runat="server" Text="Estado: "></asp:Label></b><asp:Label ID="lbEstado" runat="server"></asp:Label>
                </div>
            </div>
            <div id="conteudo-1-3">
                <hr />
                <b>
                    <asp:Label ID="Label1" runat="server" Text="Descrição: "></asp:Label>
                    <asp:ImageButton ID="btEditarDescricao" runat="server" Height="25px" Width="25px" ImageUrl="~/Imagens/Conteudo/settings.png" OnClick="btEditarDescricao_Click" ValidationGroup="ValidarDescricao" />
                    <asp:ImageButton ID="btCruzDescricao" runat="server" Height="25px" ImageUrl="~/Imagens/Conteudo/cruz.png" Visible="False" Width="25px" OnClick="btCruzDescricao_Click" />
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
                <asp:Label ID="Label4" runat="server" Text="Tipo de Vinho: "></asp:Label></b><asp:Label ID="lbTipo" runat="server"></asp:Label>
            <asp:DropDownList ID="cbTipox" runat="server" Width="164px"  Visible="false" Enabled="false">
            </asp:DropDownList>

            <asp:ImageButton ID="btEditarTipo" runat="server" Height="25px" Width="25px" ImageUrl="~/Imagens/Conteudo/settings.png" ValidationGroup="ValidarTipo" OnClick="btEditarTipo_Click" />
            <asp:ImageButton ID="btCruzTipo" runat="server" Height="25px" ImageUrl="~/Imagens/Conteudo/cruz.png" Visible="False" Width="25px" OnClick="btCruzTipo_Click" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="cbTipox" ErrorMessage="*" ValidationGroup="ValidarTipo" ForeColor="#FF3300"></asp:RequiredFieldValidator>

            <br />
            <br />
            <b>
                <asp:Label ID="Label10" runat="server" Text="Ano: "></asp:Label></b><asp:Label ID="lbAno" runat="server"></asp:Label>
            <asp:TextBox ID="txAnox" runat="server" TextMode="Number" Width="86px" min="1900" MaxLength="2100" Visible="false" Enabled="false"></asp:TextBox>
            <asp:ImageButton ID="btEditarAno" runat="server" Height="25px" Width="25px" ImageUrl="~/Imagens/Conteudo/settings.png" ValidationGroup="ValidarAno" OnClick="btEditarAno_Click" />
            <asp:ImageButton ID="btCruzAno" runat="server" Height="25px" ImageUrl="~/Imagens/Conteudo/cruz.png" Visible="False" Width="25px" OnClick="btCruzAno_Click" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txAnox" ErrorMessage="*" ValidationGroup="ValidarAno" ForeColor="#FF3300"></asp:RequiredFieldValidator>

            <br />
            <br />
            <b>
                <asp:Label ID="Label6" runat="server" Text="Região: "></asp:Label></b><asp:Label ID="lbRegiao" runat="server"></asp:Label>
            <asp:DropDownList ID="cbRegiaoxx" runat="server" Width="136px"  Visible="false" Enabled="false"></asp:DropDownList>
            <asp:ImageButton ID="btEditarRegiao" runat="server" Height="25px" Width="25px" ImageUrl="~/Imagens/Conteudo/settings.png" ValidationGroup="ValidarRegiao" OnClick="btEditarRegiao_Click" />

            <asp:ImageButton ID="btCruzRegiao" runat="server" Height="25px" ImageUrl="~/Imagens/Conteudo/cruz.png" Visible="False" Width="25px" OnClick="btCruzRegiao_Click" />

            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="cbRegiaoxx" ErrorMessage="*" ValidationGroup="ValidarRegiao" ForeColor="#FF3300"></asp:RequiredFieldValidator>

            <br />
            <br />
            <b>
                <asp:Label ID="Label3" runat="server" Text="Produtor: "></asp:Label></b><asp:Label ID="lbProdutor" runat="server"></asp:Label>
            <asp:DropDownList ID="cbProdutorx" runat="server" Width="144px" Visible="false" Enabled="false"></asp:DropDownList>
            <asp:ImageButton ID="btEditarProdutor" runat="server" Height="25px" Width="25px" ImageUrl="~/Imagens/Conteudo/settings.png" ValidationGroup="ValidarProdutor" OnClick="btEditarProdutor_Click" />
            <asp:ImageButton ID="btCruzProdutor" runat="server" Height="25px" ImageUrl="~/Imagens/Conteudo/cruz.png" Visible="False" Width="25px" OnClick="btCruzProdutor_Click" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="cbProdutorx" ErrorMessage="*" ValidationGroup="ValidarProdutor" ForeColor="#FF3300"></asp:RequiredFieldValidator>


        </div>

        <div id="conteudo-2-1">
            <hr />
            <b>
                <asp:Label ID="Label7" runat="server" Text="Temperatura: "></asp:Label></b>
            <asp:Label ID="lbTemperatura" runat="server"></asp:Label>
            <asp:TextBox ID="txTemperaturax" runat="server" Width="86px" Visible="false" Enabled="false"></asp:TextBox>
            <b>
                <asp:Label ID="Label24" runat="server" Text="ºC"></asp:Label></b><asp:ImageButton ID="btEditarTempura" runat="server" Height="25px" Width="25px" ImageUrl="~/Imagens/Conteudo/settings.png" ValidationGroup="ValidarTempura" OnClick="btEditarTempura_Click" />
            <asp:ImageButton ID="btCruzTempura" runat="server" Height="25px" ImageUrl="~/Imagens/Conteudo/cruz.png" Visible="False" Width="25px" OnClick="btCruzTempura_Click" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txTemperaturax" ErrorMessage="*" ValidationGroup="ValidarTempura" ForeColor="#FF3300"></asp:RequiredFieldValidator>


            <br />
            <br />
            <b>
                <asp:Label ID="Label8" runat="server" Text="Teor Alcoólico: "></asp:Label></b><asp:Label ID="lbTeorAlcoolico" runat="server"></asp:Label>
            <asp:TextBox ID="txTeorAlcoolicox" runat="server" TextMode="Number" Width="66px" Visible="false" Enabled="false" Min="5"></asp:TextBox>
            <b>
                <asp:Label ID="Label22" runat="server" Text=" %vol"></asp:Label></b>
            <asp:ImageButton ID="btEditarTeor" runat="server" Height="25px" Width="25px" ImageUrl="~/Imagens/Conteudo/settings.png" ValidationGroup="ValidarTeor" OnClick="btEditarTeor_Click" />
            <asp:ImageButton ID="btCruzTeor" runat="server" Height="25px" ImageUrl="~/Imagens/Conteudo/cruz.png" Visible="False" Width="25px" OnClick="btCruzTeor_Click" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txTeorAlcoolicox" ErrorMessage="*" ValidationGroup="ValidarTeor" ForeColor="#FF3300"></asp:RequiredFieldValidator>

            <br />
            <br />
            <b>
                <asp:Label ID="Label9" runat="server" Text="Volume: "></asp:Label></b>
            <asp:Label ID="lbVolume" runat="server"></asp:Label>
            <asp:TextBox ID="txVolumex" runat="server" TextMode="Number" Width="86px" Visible="false" Enabled="false" min="5"></asp:TextBox>
            <b>
                <asp:Label ID="Label2" runat="server" Text=" ml"></asp:Label></b>
            <asp:ImageButton ID="btEditarVolume" runat="server" Height="25px" Width="25px" ImageUrl="~/Imagens/Conteudo/settings.png" ValidationGroup="ValidarVolume" OnClick="btEditarVolume_Click" />
            <asp:ImageButton ID="btCruzVolume" runat="server" Height="25px" ImageUrl="~/Imagens/Conteudo/cruz.png" Visible="False" Width="25px" OnClick="btCruzVolume_Click" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="txVolumex" ErrorMessage="*" ValidationGroup="ValidarVolume" ForeColor="#FF3300"></asp:RequiredFieldValidator>



        </div>
        <div id="conteudo-3">
            <asp:GridView ID="gridVinho" runat="server"  ShowHeader="False" Visible="False">
            </asp:GridView>
            <br />
            <br />

        </div>

        <div id="conteudo-4">
            <hr />
            <div id="conteudo-4-1">

                <b>
                    <asp:Label ID="Label12" runat="server" Text="Castas:"></asp:Label></b><asp:Label ID="lbTotaldaCasta" runat="server" Text=""></asp:Label>
                <asp:ImageButton ID="btEditarCasta" runat="server" Height="25px" Width="25px" ImageUrl="~/Imagens/Conteudo/settings.png" ValidationGroup="validarCasta" OnClick="btEditarCasta_Click" />


                <asp:ImageButton ID="btCruzCasta" runat="server" Height="25px" Width="25px" ImageUrl="~/Imagens/Conteudo/cruz.png" Visible="False" OnClick="btCruzCasta_Click"/>


                <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="lbxxCastas" ErrorMessage="*" ValidationGroup="validarCasta" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                <br />
                <asp:Repeater ID="RepeaterCasta" runat="server">
                    <ItemTemplate>
                        <div class="casta">

                            <%--<b> NEGRITO </b> --%>
                            <asp:Label ID="Label27" runat="server" Text='<%#Eval("Percentagem") %>'></asp:Label>
                            %&nbsp;<asp:Label ID="Label28" runat="server" Text='<%#Eval("NomeCasta") %>'></asp:Label>

                            <br />
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
                <br />
                <asp:ListBox ID="lbxxCastas" runat="server" Height="220px" Width="250px" SelectionMode="Multiple" Visible="false" Enabled="false"></asp:ListBox>


                <br />
                <asp:Label ID="lbInformacaoCasta" runat="server" Text="" Visible="false"></asp:Label>


                <br />
                



            </div>


            <div id="conteudo-4-2">
                <b>
                    <asp:Label ID="Label11" runat="server" Text="Enologos:"></asp:Label></b>
                <asp:ImageButton ID="btEditarEnologo" runat="server" Height="25px" Width="25px" ImageUrl="~/Imagens/Conteudo/settings.png" ValidationGroup="ValidarEnologo" OnClick="btEditarEnolgo_Click" />
                <asp:ImageButton ID="btCruzEnologo" runat="server" Height="25px" ImageUrl="~/Imagens/Conteudo/cruz.png" Visible="False" Width="25px" OnClick="btCruzEnologo_Click" />
                <asp:RequiredFieldValidator ID="validarEnologos" runat="server" ControlToValidate="lbxxEnologos" ErrorMessage="*" ValidationGroup="ValidarEnologo" ForeColor="#FF3300"></asp:RequiredFieldValidator><br />
                <asp:Repeater ID="RepeaterEnologo" runat="server">
                    <ItemTemplate>
                        <div class="enologo">
                            <asp:Label ID="Label29" runat="server" Text='<%#Eval("NomeEnologo") %>'></asp:Label>

                            <br />
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
                <br />
                <asp:ListBox ID="lbxxEnologos" runat="server" Height="220px" SelectionMode="Multiple" Width="250px" Visible="false" Enabled="false"></asp:ListBox>
                <br />
                <asp:Label ID="lbInformacaoEnologo" runat="server" Text="" Visible="false"></asp:Label>

                
            </div>

        </div>
    </div>
</asp:Content>
