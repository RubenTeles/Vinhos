using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using DALL;
using Microsoft.VisualBasic;

namespace Site_Vinhao.UtilizadoresRegistados
{
    public partial class CriarVinho : System.Web.UI.Page
    {
        bool inserir = false;

        protected void Page_Load(object sender, EventArgs e)
        {


            if (!IsPostBack)
            {
                PreencherList();


            }



        }

        void PreencherList()
        {
            //--Produtor--
            cbProdutor.DataSource = Produtor_Metodos.ProdutorSelect();
            cbProdutor.DataTextField = "NomeProdutor";
            cbProdutor.DataValueField = "ProdutorID";
            cbProdutor.DataBind();

            //--Região--
            cbRegiao.DataSource = Regiao_Metodos.RegiaoSelect();
            cbRegiao.DataTextField = "NomeRegiao";
            cbRegiao.DataValueField = "IDRegiao";
            cbRegiao.DataBind();

            //--Tipo de Vinho--
            cbTipo.DataSource = Tipo_Metodos.TipoSelect();
            cbTipo.DataTextField = "NomeTipo";
            cbTipo.DataValueField = "TipoID";
            cbTipo.DataBind();

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

        bool AdicionarEnologo(int idVinho)
        {
            //---Enologos
            bool enologoaceite = false;


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

        decimal AdicionarCasta(int idVinho)
        {
            //--Castas

            string mensagem = "a1";
            int casta = 0;
            decimal percentagem = 0;
            decimal percentagemTotal = 0;

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
                                lbPercentagemTotal.Text = "0";
                            }

                            percentagemTotal = decimal.Parse(lbPercentagem.Text);

                            if ((percentagemTotal + percentagem) <= 100)
                            {
                                aceite = true;

                                CastasVinhos novaCasta = new CastasVinhos();
                                novaCasta.CastaID = id;
                                novaCasta.VinhoID = idVinho;
                                novaCasta.Percentagem = percentagem;

                                lbPercentagem.Text = CastasVinhos_Metodos.InserirCastasVinhos(novaCasta).ToString();
                                percentagemTotal = percentagemTotal + percentagem;
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


            return percentagemTotal;
        }
        protected void btInserir_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    string UserID = Session["id_utilizador"].ToString();
                    int UtilizadorID = int.Parse(Utilizador_Metodos.UtilizadorObterID(UserID));
                }
                catch (Exception)
                {

                    int UtilizadorID = int.Parse(Session["id_utilizador"].ToString());
                }
            }
            catch (Exception)
            {
                Response.Redirect("~/ASP/Home.aspx");
            }


            Vinho adicionarVinho = new Vinho();

            adicionarVinho.NomeVinho = txNome.Text;
            adicionarVinho.Descricao = txDescricao.Text;
            adicionarVinho.UtilizadorID = int.Parse(Session["id_utilizador"].ToString());
            adicionarVinho.ProdutorID = int.Parse(cbProdutor.SelectedValue);
            adicionarVinho.RegiaoID = int.Parse(cbRegiao.SelectedValue);
            adicionarVinho.TipoID = int.Parse(cbTipo.SelectedValue);
            adicionarVinho.Ano = int.Parse(txAno.Text.Trim());
            adicionarVinho.Temperatura = txTemperatura.Text;
            adicionarVinho.TeorAlcoolico = decimal.Parse(txTeorAlcoolico.Text.Trim());
            adicionarVinho.Volume = decimal.Parse(txVolume.Text.Trim());
            //foto – verificar a existência de ficheiro e o tipo

            if (uploadFoto.HasFile)
            {
                bool ok = false;
                string[] ext = { ".jpg", ".jpeg", ".png", ".gif", ".tiff" };
                string extensao = System.IO.Path.GetExtension(uploadFoto.FileName).ToString();
                foreach (var item in ext)
                {
                    if (extensao == item) ok = true;
                }
                if (ok)
                {
                    uploadFoto.SaveAs(Server.MapPath("~/Imagens/") + uploadFoto.FileName);
                    adicionarVinho.Foto = "~/Imagens/" + uploadFoto.FileName;
                }
                else
                    adicionarVinho.Foto = "";
            }
            else
                adicionarVinho.Foto = "";


            int idVinho = int.Parse(Vinho_Metodos.VinhoInsert(adicionarVinho));



            bool enologoaceite = AdicionarEnologo(idVinho);

            decimal total = AdicionarCasta(idVinho);
            if (total < 0 | total <100)
            {
                MessageBox.Show("As Castas do Vinho " + txNome.Text + " contêm apenas " + total + " no total!", "Atenção!");
                //Editar_Vinho
                Response.Redirect("~/UtilizadoresRegistados/EditarVinho.aspx?vinho=" + idVinho);
                //castaaceite = AdicionarCasta(idVinho);
            }

            if (enologoaceite == true && total == 100)
            {
                MessageBox.Show("Foi adicionado o Novo Vinho " + txNome.Text + "!", "Parabéns!");
                Response.Redirect("~/ASP/Perfil.aspx");
            }



            //regressar à área pessoal
        }
    }
}
