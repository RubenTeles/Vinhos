using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using DALL;
using Microsoft.VisualBasic;

namespace Site_Vinhao.UtilizadoresRegistados
{
    public partial class EditarVinho : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bool user = false;
                int UtilizadorID = -1;
                try
                {
                    try
                    {
                        string UserID = Session["id_utilizador"].ToString();
                        UtilizadorID = int.Parse(Utilizador_Metodos.UtilizadorObterID(UserID));
                        string nome = Utilizador_Metodos.UtilizadorObterNome(UtilizadorID);

                        user = true;

                    }
                    catch (Exception)
                    {

                        UtilizadorID = int.Parse(Session["id_utilizador"].ToString());
                        string nome = Utilizador_Metodos.UtilizadorObterNome(UtilizadorID);

                        user = true;

                    }

                }
                catch (Exception)
                {
                    //Caso não seja Utilizador Registado
                    Response.Redirect("~/ASP/login.aspx");
                    user = false;

                }


                PreencherList();

                int vinho = 0;
                //preencher castas
                if (Request.QueryString["vinho"] != null)
                    vinho = int.Parse(Request.QueryString["vinho"].ToString());

                int id = getVinho(vinho);

                if (user == true && UtilizadorID != id)//Caso seja o Utilizador
                {
                    Response.Redirect("~/ASP/Home.aspx");
                }

            }


        }
        void PreencherList()
        {
            //--Produtor--
            cbProdutorx.DataSource = Produtor_Metodos.ProdutorSelect();
            cbProdutorx.DataTextField = "NomeProdutor";
            cbProdutorx.DataValueField = "ProdutorID";
            cbProdutorx.DataBind();

            //--Região--
            cbRegiaoxx.DataSource = Regiao_Metodos.RegiaoSelect();
            cbRegiaoxx.DataTextField = "NomeRegiao";
            cbRegiaoxx.DataValueField = "IDRegiao";
            cbRegiaoxx.DataBind();

            //--Tipo de Vinho--
            cbTipox.DataSource = Tipo_Metodos.TipoSelect();
            cbTipox.DataTextField = "NomeTipo";
            cbTipox.DataValueField = "TipoID";
            cbTipox.DataBind();

            //--Castas--
            lbxxCastas.DataSource = Casta_Metodos.CastaSelect();
            lbxxCastas.DataTextField = "NomeCasta";
            lbxxCastas.DataValueField = "IdCastas";
            lbxxCastas.DataBind();

            //--Enologos--
            lbxxEnologos.DataSource = Enologo_Metodos.EnologoSelect();
            lbxxEnologos.DataTextField = "NomeEnologo";
            lbxxEnologos.DataValueField = "EnologoID";
            lbxxEnologos.DataBind();
        }

        int getVinho(int vinho)
        {
            gridVinho.DataSource = Vinho_Metodos.VinhoSelectByVinhoIDPorAprovar(vinho);
            gridVinho.DataBind();

            gridVinho.SelectRow(0);


            GridViewRow row = gridVinho.SelectedRow;

            lbVinhoID.Text = row.Cells[0].Text;
            lbNomeVinho.Text = row.Cells[1].Text;
            lbDescricao.Text = row.Cells[2].Text;
            foto.ImageUrl = row.Cells[4].Text;
            lbAno.Text = row.Cells[5].Text;
            lbVolume.Text = row.Cells[6].Text;
            lbTeorAlcoolico.Text = row.Cells[7].Text;
            lbTemperatura.Text = row.Cells[8].Text;
            lbEstado.Text = row.Cells[9].Text;
            lbTipo.Text = row.Cells[11].Text;
            lbRegiao.Text = row.Cells[13].Text;
            lbProdutor.Text = row.Cells[15].Text;
            int id = int.Parse(row.Cells[16].Text);
            txNomeUtilizador.Text = row.Cells[17].Text;

            //txNomeVinho.Text = row.Cells[1].Text;
            //txtDescricao.Text = row.Cells[2].Text;
            //txAnox.Text = row.Cells[5].Text;
            //txVolumex.Text = row.Cells[6].Text;
            //txTeorAlcoolicox.Text = row.Cells[7].Text;
            //txTemperaturax.Text = row.Cells[8].Text;

            RepeaterCasta.DataSource = CastasVinhos_Metodos.VerCastasdoVinhos(vinho);
            RepeaterCasta.DataBind();


            RepeaterEnologo.DataSource = EnologosVinhos_Metodos.VerEnologosdoVinhos(vinho);
            RepeaterEnologo.DataBind();

            decimal total = CastasVinhos_Metodos.MostrarPercentagemTotal(id);
            lbTotaldaCasta.Text = "(" + total + ")";
            if (total < 100)
            {
                lbTotaldaCasta.BackColor = Color.Red;
            }

            return id;
        }

        protected void btEditarNomeVinho_Click(object sender, ImageClickEventArgs e)
        {
            if (txNomeVinho.Visible == true)
            {
                txNomeVinho.Visible = false;
                txNomeVinho.Enabled = false;
                btEditarNomeVinho.ImageUrl = "~/Imagens/Conteudo/settings.png";
                btCruzNomeVinho.Visible = false;

                int idVinho = int.Parse(lbVinhoID.Text);

                Vinho update = new Vinho();
                update.VinhoID = idVinho;
                update.NomeVinho = txNomeVinho.Text;


                Editar_Metodos.NomeUpdate(update);

                getVinho(idVinho);
            }

            else if (txNomeVinho.Visible == false)
            {
                txNomeVinho.Visible = true;
                txNomeVinho.Enabled = true;
                btEditarNomeVinho.ImageUrl = "~/Imagens/Conteudo/certo.png";
                btCruzNomeVinho.Visible = true;
            }
        }
        protected void btCruzNomeVinho_Click(object sender, ImageClickEventArgs e)
        {
            txNomeVinho.Visible = false;
            txNomeVinho.Enabled = false;
            btEditarNomeVinho.ImageUrl = "~/Imagens/Conteudo/settings.png";
            btCruzNomeVinho.Visible = false;
        }

        protected void btEditarDescricao_Click(object sender, ImageClickEventArgs e)
        {
            if (txtDescricao.Visible == true)
            {
                txtDescricao.Visible = false;
                txtDescricao.Enabled = false;
                btEditarDescricao.ImageUrl = "~/Imagens/Conteudo/settings.png";
                btCruzDescricao.Visible = false;

                int idVinho = int.Parse(lbVinhoID.Text);

                Vinho update = new Vinho();
                update.VinhoID = idVinho;
                update.Descricao = txtDescricao.Text;


                Editar_Metodos.DescricaoUpdate(update);

                getVinho(idVinho);
            }

            else if (txtDescricao.Visible == false)
            {
                txtDescricao.Visible = true;
                txtDescricao.Enabled = true;
                btEditarDescricao.ImageUrl = "~/Imagens/Conteudo/certo.png";
                btCruzDescricao.Visible = true;
            }
        }
        protected void btCruzDescricao_Click(object sender, ImageClickEventArgs e)
        {
            txtDescricao.Visible = false;
            txtDescricao.Enabled = false;
            btEditarDescricao.ImageUrl = "~/Imagens/Conteudo/settings.png";
            btCruzDescricao.Visible = false;
        }

        protected void btEditarImagem_Click(object sender, ImageClickEventArgs e)
        {
            if (updateFoto.Visible == true)
            {
                updateFoto.Visible = false;
                updateFoto.Enabled = false;
                btEditarImagem.ImageUrl = "~/Imagens/Conteudo/settings.png";
                btCruzFoto.Visible = false;

                int idVinho = int.Parse(lbVinhoID.Text);

                Vinho update = new Vinho();
                update.VinhoID = idVinho;

                if (updateFoto.HasFile)
                {
                    bool ok = false;
                    string[] ext = { ".jpg", ".jpeg", ".png", ".gif", ".tiff" };
                    string extensao = System.IO.Path.GetExtension(updateFoto.FileName).ToString();
                    foreach (var item in ext)
                    {
                        if (extensao == item) ok = true;
                    }
                    if (ok)
                    {
                        updateFoto.SaveAs(Server.MapPath("~/Imagens/Perfil/") + updateFoto.FileName);
                        update.Foto = "~/Imagens/Perfil/" + updateFoto.FileName;
                    }
                    else
                        update.Foto = "~/Imagens/Conteudo/perfil.png";
                }
                else
                    update.Foto = "~/Imagens/Conteudo/perfil.png";


                Editar_Metodos.FotoUpdate(update);

                getVinho(idVinho);
            }

            else if (updateFoto.Visible == false)
            {
                updateFoto.Visible = true;
                updateFoto.Enabled = true;
                btEditarImagem.ImageUrl = "~/Imagens/Conteudo/certo.png";
                btCruzFoto.Visible = true;
            }
        }
        protected void btCruzFoto_Click(object sender, ImageClickEventArgs e)
        {
            updateFoto.Visible = false;
            updateFoto.Enabled = false;
            btEditarImagem.ImageUrl = "~/Imagens/Conteudo/settings.png";
            btCruzFoto.Visible = false;
        }

        protected void btEditarTipo_Click(object sender, ImageClickEventArgs e)
        {
            if (cbTipox.Visible == true)
            {
                cbTipox.Visible = false;
                cbTipox.Enabled = false;
                btEditarTipo.ImageUrl = "~/Imagens/Conteudo/settings.png";
                btCruzTipo.Visible = false;

                int idVinho = int.Parse(lbVinhoID.Text);

                Vinho update = new Vinho();
                update.VinhoID = idVinho;
                update.TipoID = int.Parse(cbTipox.SelectedValue);


                Editar_Metodos.TipoUpdate(update);

                getVinho(idVinho);
            }

            else if (cbTipox.Visible == false)
            {
                cbTipox.Visible = true;
                cbTipox.Enabled = true;
                btEditarTipo.ImageUrl = "~/Imagens/Conteudo/certo.png";
                btCruzTipo.Visible = true;
            }
        }
        protected void btCruzTipo_Click(object sender, ImageClickEventArgs e)
        {
            cbTipox.Visible = false;
            cbTipox.Enabled = false;
            btEditarTipo.ImageUrl = "~/Imagens/Conteudo/settings.png";
            btCruzTipo.Visible = false;
        }

        protected void btEditarAno_Click(object sender, ImageClickEventArgs e)
        {
            if (txAnox.Visible == true)
            {
                txAnox.Visible = false;
                txAnox.Enabled = false;
                btEditarAno.ImageUrl = "~/Imagens/Conteudo/settings.png";
                btCruzAno.Visible = false;

                int idVinho = int.Parse(lbVinhoID.Text);

                Vinho update = new Vinho();
                update.VinhoID = idVinho;
                update.Ano = int.Parse(txAnox.Text.Trim());


                Editar_Metodos.AnoUpdate(update);

                getVinho(idVinho);
            }

            else if (txAnox.Visible == false)
            {
                txAnox.Visible = true;
                txAnox.Enabled = true;
                btEditarAno.ImageUrl = "~/Imagens/Conteudo/certo.png";
                btCruzAno.Visible = true;
            }
        }
        protected void btCruzAno_Click(object sender, ImageClickEventArgs e)
        {
            txAnox.Visible = false;
            txAnox.Enabled = false;
            btEditarAno.ImageUrl = "~/Imagens/Conteudo/settings.png";
            btCruzAno.Visible = false;
        }

        protected void btEditarRegiao_Click(object sender, ImageClickEventArgs e)
        {
            if (cbRegiaoxx.Visible == true)
            {
                cbRegiaoxx.Visible = false;
                cbRegiaoxx.Enabled = false;
                btEditarRegiao.ImageUrl = "~/Imagens/Conteudo/settings.png";
                btCruzRegiao.Visible = false;

                int idVinho = int.Parse(lbVinhoID.Text);

                Vinho update = new Vinho();
                update.VinhoID = idVinho;
                update.RegiaoID = int.Parse(cbRegiaoxx.SelectedValue);


                Editar_Metodos.RegiaoUpdate(update);

                getVinho(idVinho);
            }

            else if (cbRegiaoxx.Visible == false)
            {
                cbRegiaoxx.Visible = true;
                cbRegiaoxx.Enabled = true;
                btEditarRegiao.ImageUrl = "~/Imagens/Conteudo/certo.png";
                btCruzRegiao.Visible = true;
            }
        }
        protected void btCruzRegiao_Click(object sender, ImageClickEventArgs e)
        {
            cbRegiaoxx.Visible = false;
            cbRegiaoxx.Enabled = false;
            btEditarRegiao.ImageUrl = "~/Imagens/Conteudo/settings.png";
            btCruzRegiao.Visible = false;
        }

        protected void btEditarProdutor_Click(object sender, ImageClickEventArgs e)
        {
            if (cbProdutorx.Visible == true)
            {
                cbProdutorx.Visible = false;
                cbProdutorx.Enabled = false;
                btEditarProdutor.ImageUrl = "~/Imagens/Conteudo/settings.png";
                btCruzProdutor.Visible = false;

                int idVinho = int.Parse(lbVinhoID.Text);

                Vinho update = new Vinho();
                update.VinhoID = idVinho;
                update.ProdutorID = int.Parse(cbProdutorx.SelectedValue);


                Editar_Metodos.ProdutorUpdate(update);

                getVinho(idVinho);
            }

            else if (cbProdutorx.Visible == false)
            {
                cbProdutorx.Visible = true;
                cbProdutorx.Enabled = true;
                btEditarProdutor.ImageUrl = "~/Imagens/Conteudo/certo.png";
                btCruzProdutor.Visible = true;
            }
        }
        protected void btCruzProdutor_Click(object sender, ImageClickEventArgs e)
        {
            cbProdutorx.Visible = false;
            cbProdutorx.Enabled = false;
            btEditarProdutor.ImageUrl = "~/Imagens/Conteudo/settings.png";
            btCruzProdutor.Visible = false;
        }


        protected void btEditarTempura_Click(object sender, ImageClickEventArgs e)
        {
            if (txTemperaturax.Visible == true)
            {
                txTemperaturax.Visible = false;
                txTemperaturax.Enabled = false;
                btEditarTempura.ImageUrl = "~/Imagens/Conteudo/settings.png";
                btCruzTempura.Visible = false;

                int idVinho = int.Parse(lbVinhoID.Text);

                Vinho update = new Vinho();
                update.VinhoID = idVinho;
                update.Temperatura = txTemperaturax.Text;


                Editar_Metodos.TempuraUpdate(update);

                getVinho(idVinho);
            }

            else if (txTemperaturax.Visible == false)
            {
                txTemperaturax.Visible = true;
                txTemperaturax.Enabled = true;
                btEditarTempura.ImageUrl = "~/Imagens/Conteudo/certo.png";
                btCruzTempura.Visible = true;
            }
        }
        protected void btCruzTempura_Click(object sender, ImageClickEventArgs e)
        {
            txTemperaturax.Visible = false;
            txTemperaturax.Enabled = false;
            btEditarTempura.ImageUrl = "~/Imagens/Conteudo/settings.png";
            btCruzTempura.Visible = false;
        }

        protected void btEditarTeor_Click(object sender, ImageClickEventArgs e)
        {
            if (txTeorAlcoolicox.Visible == true)
            {
                txTeorAlcoolicox.Visible = false;
                txTeorAlcoolicox.Enabled = false;
                btEditarTeor.ImageUrl = "~/Imagens/Conteudo/settings.png";
                btCruzTeor.Visible = false;

                int idVinho = int.Parse(lbVinhoID.Text);

                Vinho update = new Vinho();
                update.VinhoID = idVinho;
                update.TeorAlcoolico = decimal.Parse(txTeorAlcoolicox.Text.Trim());


                Editar_Metodos.TeorUpdate(update);

                getVinho(idVinho);
            }

            else if (txTeorAlcoolicox.Visible == false)
            {
                txTeorAlcoolicox.Visible = true;
                txTeorAlcoolicox.Enabled = true;
                btEditarTeor.ImageUrl = "~/Imagens/Conteudo/certo.png";
                btCruzTeor.Visible = true;
            }
        }
        protected void btCruzTeor_Click(object sender, ImageClickEventArgs e)
        {
            txTeorAlcoolicox.Visible = false;
            txTeorAlcoolicox.Enabled = false;
            btEditarTempura.ImageUrl = "~/Imagens/Conteudo/settings.png";
            btCruzTeor.Visible = false;
        }

        protected void btEditarVolume_Click(object sender, ImageClickEventArgs e)
        {
            if (txVolumex.Visible == true)
            {
                txVolumex.Visible = false;
                txVolumex.Enabled = false;
                btEditarVolume.ImageUrl = "~/Imagens/Conteudo/settings.png";
                btCruzVolume.Visible = false;

                int idVinho = int.Parse(lbVinhoID.Text);

                Vinho update = new Vinho();
                update.VinhoID = idVinho;
                update.Volume = decimal.Parse(txVolumex.Text.Trim());


                Editar_Metodos.VolumeUpdate(update);

                getVinho(idVinho);
            }

            else if (txVolumex.Visible == false)
            {
                txVolumex.Visible = true;
                txVolumex.Enabled = true;
                btEditarVolume.ImageUrl = "~/Imagens/Conteudo/certo.png";
                btCruzVolume.Visible = true;
            }
        }
        protected void btCruzVolume_Click(object sender, ImageClickEventArgs e)
        {
            txVolumex.Visible = false;
            txVolumex.Enabled = false;
            btEditarVolume.ImageUrl = "~/Imagens/Conteudo/settings.png";
            btCruzVolume.Visible = false;
        }
        protected void btEditarCasta_Click(object sender, ImageClickEventArgs e)
        {
            if (lbxxCastas.Visible == true)
            {
                lbxxCastas.Visible = false;
                lbxxCastas.Enabled = false;
                lbInformacaoCasta.Visible = false;
                btEditarCasta.ImageUrl = "~/Imagens/Conteudo/settings.png";
                btCruzCasta.Visible = false;


                int idVinho = int.Parse(lbVinhoID.Text);



                EditarCasta(idVinho);

                getVinho(idVinho);
            }

            else if (lbxxCastas.Visible == false)
            {
                lbxxCastas.Visible = true;
                lbxxCastas.Enabled = true;
                btEditarCasta.ImageUrl = "~/Imagens/Conteudo/certo.png";
                btCruzCasta.Visible = true;
                lbInformacaoCasta.Visible = true;
                lbInformacaoCasta.Text = "As Castas que Inserir serão substituídas pelas atuais.\nCaso as queira substituir as castas no total têm de ter 100% para o vinho ser Aprovado.\nUse a Tecla CTRL para selecionar várias Castas.";
            }
        }
        protected void btCruzCasta_Click(object sender, ImageClickEventArgs e)
        {
            lbxxCastas.Visible = false;
            lbxxCastas.Enabled = false;
            lbInformacaoCasta.Visible = false;
            btEditarCasta.ImageUrl = "~/Imagens/Conteudo/settings.png";
            btCruzCasta.Visible = false;
        }
        protected void btEditarEnolgo_Click(object sender, ImageClickEventArgs e)
        {
            if (lbxxEnologos.Visible == true)
            {
                lbxxEnologos.Visible = false;
                lbxxEnologos.Enabled = false;
                lbInformacaoEnologo.Visible = false;
                btEditarEnologo.ImageUrl = "~/Imagens/Conteudo/settings.png";
                btCruzEnologo.Visible = false;

                int idVinho = int.Parse(lbVinhoID.Text);

                EditarEnologo(idVinho);

                getVinho(idVinho);
            }

            else if (lbxxCastas.Visible == false)
            {
                lbxxEnologos.Visible = true;
                lbxxEnologos.Enabled = true;
                btEditarEnologo.ImageUrl = "~/Imagens/Conteudo/certo.png";
                btCruzEnologo.Visible = true;
                lbInformacaoEnologo.Visible = true;
                lbInformacaoEnologo.Text = "O/Os Enologo/os que Inserir serão substituídas pelos atuais.\nUse a Tecla CTRL para selecionar vários Enólogos.";

            }
        }
        protected void btCruzEnologo_Click(object sender, ImageClickEventArgs e)
        {
            lbxxEnologos.Visible = false;
            lbxxEnologos.Enabled = false;
            lbInformacaoEnologo.Visible = false;
            btEditarEnologo.ImageUrl = "~/Imagens/Conteudo/settings.png";
            btCruzEnologo.Visible = false;
        }

        bool EditarEnologo(int idVinho)
        {
            //---Enologos
            bool enologoaceite = false;

            Editar_Metodos.EnologoUpdate(idVinho);

            foreach (ListItem li in lbxxEnologos.Items)
            {
                if (li.Selected == true)
                {
                    int valor = int.Parse(li.Value);
                    EnologosVinhos novoEnologo = new EnologosVinhos();
                    novoEnologo.EnologoID = valor;
                    novoEnologo.VinhoID = idVinho;

                    EnologosVinhos_Metodos.EnologosInsert(novoEnologo);

                }

                enologoaceite = true;
            }


            return enologoaceite;
        }

        decimal EditarCasta(int idVinho)
        {
            //--Castas

            string mensagem = "a1";
            int casta = 0;
            decimal percentagem = 0;

            Editar_Metodos.CastaUpdate(idVinho);

            foreach (int i in lbxxCastas.GetSelectedIndices())
            {
                lbxxCastas.Items[i].ToString();
            }


            foreach (ListItem li in lbxxCastas.Items)
            {
                if (li.Selected == true)
                {
                    int id = int.Parse(li.Value);
                    string nome = li.Text;



                    bool aceite = false;


                    do
                    {
                        do
                        {

                            mensagem = Interaction.InputBox("Qual é a Percentagem da Casta " + nome, "Percentagem", "", -1, -1);

                            mensagem.Replace(",", ".");
                            if (mensagem != "")//Caso a Interaction Não Seja Cancelada!
                            {
                                if (decimal.TryParse(mensagem, out percentagem))
                                {
                                }
                                else
                                {
                                    mensagem = "a1";
                                    MessageBox.Show("O formato que escreveu não é em percentagem.\nEscreva algo como '22,23'", "Alerta!");
                                }
                            }


                        } while (mensagem == "a1");

                        if (mensagem != "")//Caso a Interaction Não Seja Cancelada!
                        {
                            if (lbPercentagem.Text == "")
                            {
                                lbPercentagem.Text = "0";
                            }

                            decimal percentagemTotal = decimal.Parse(lbPercentagem.Text);

                            if ((percentagemTotal + percentagem) <= 100)
                            {
                                aceite = true;

                                CastasVinhos novaCasta = new CastasVinhos();
                                novaCasta.CastaID = id;
                                novaCasta.VinhoID = idVinho;
                                novaCasta.Percentagem = percentagem;

                                lbPercentagem.Text = CastasVinhos_Metodos.InserirCastasVinhos(novaCasta).ToString();

                                ++casta;
                            }
                            else if ((percentagemTotal + percentagem) > 100)
                            {
                                aceite = false;

                                MessageBox.Show("A percentagem da excede o Limite!\nPor Favor coloque um numero até " + (100 - percentagemTotal), "Alerta!");

                            }

                        }
                        else if (mensagem == "")
                        {
                            MessageBox.Show("A Casta " + nome + " foi Eliminada!", "Atenção!");
                            aceite = true;
                        }

                    } while (aceite == false);



                }
            }


            return casta;
        }

        protected void lbxxEnologos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}