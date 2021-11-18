using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using DALL;

namespace Site_Vinhao.ASP
{
    public partial class Vinho : System.Web.UI.Page
    {
        static SqlConnection vinhao_conexao = new SqlConnection("Data Source = localhost; Initial Catalog = Vinhao; Integrated Security = True");

        protected void Page_Load(object sender, EventArgs e)
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

                    txNomeComentario.Text = nome;
                }
                catch (Exception)
                {

                    UtilizadorID = int.Parse(Session["id_utilizador"].ToString());
                    string nome = Utilizador_Metodos.UtilizadorObterNome(UtilizadorID);

                    user = true;

                    txNomeComentario.Text = nome;
                }

            }
            catch (Exception)
            {
                //Caso não seja Utilizador Registado

                user = false;

            }

            if (this.IsPostBack == false)
            {
                int vinho = 0;
                //preencher castas
                if (Request.QueryString["vinho"] != null)
                    vinho = int.Parse(Request.QueryString["vinho"].ToString());

                int id = getVinho(vinho);
                fillData(vinho);

                if (user == true && UtilizadorID != id)//Caso seja o Utilizador
                {
                    txNomeComentario.ReadOnly = true;
                    imgFavorito.Visible = true;
                    Classificacao.Visible = true;
                    getFavorito();
                    getClassificacao();
                }
                else
                {
                    fazercomentario.Visible = false;
                    imgFavorito.Visible = false;
                    Classificacao.Visible = false;
                }
            }
        }



        int getVinho(int vinho)
        {
            int id = -1;

            try
            {
                gridCastasVinho.DataSource = Vinho_Metodos.VinhoSelectByVinhoID(vinho);
                gridCastasVinho.DataBind();
                gridCastasVinho.SelectRow(0);

                GridViewRow row = gridCastasVinho.SelectedRow;

                txNome.Text = row.Cells[1].Text;
                txDescricao.Text = row.Cells[2].Text;
                foto.ImageUrl = row.Cells[4].Text;
                txAno.Text = row.Cells[5].Text;
                txVolume.Text = row.Cells[6].Text;
                txTeorAlcoolico.Text = row.Cells[7].Text;
                txTemperatura.Text = row.Cells[8].Text;
                cbTipo.Text = row.Cells[11].Text;
                cbRegiao.Text = row.Cells[13].Text;
                cbProdutor.Text = row.Cells[15].Text;
                id = int.Parse(row.Cells[16].Text);
                txNomeUtilizador.Text = row.Cells[17].Text;
            }
            catch (Exception)
            {
                Response.Redirect("~/ASP/Home.aspx");

            }




            RepeaterCasta.DataSource = CastasVinhos_Metodos.VerCastasdoVinhos(vinho);
            RepeaterCasta.DataBind();


            RepeaterEnologo.DataSource = EnologosVinhos_Metodos.VerEnologosdoVinhos(vinho);
            RepeaterEnologo.DataBind();

            lbClassificacao.Text = Comentarios_Metodos.ClassificaçãoMedia(vinho).ToString() + " ☆";


            return id;
        }

        int getFavorito()
        {
            int UtilizadorID = int.Parse(Session["id_utilizador"].ToString());
            int vinhoId = int.Parse(Request.QueryString["vinho"].ToString());


            int favorito = Vinho_Metodos.MostrarSeEFavorito(vinhoId, UtilizadorID);
            if (favorito > 0)
            {
                imgFavorito.ImageUrl = "~/Imagens/Conteudo/coracao-vermelho.png";
                imgFavorito.DescriptionUrl = "Remover dos Favoritos";
            }
            else if (favorito == 0)
            {
                imgFavorito.ImageUrl = "~/Imagens/Conteudo/coracao-vazio.png";
                imgFavorito.DescriptionUrl = "Adicionar aos Favoritos";
            }

            return favorito;
        }

        protected void btEnviar_Click(object sender, EventArgs e)
        {

        }

        protected void gridEnologosVinho_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            //    e.Row.Cells[0].Visible = false;
            //    e.Row.Cells[1].Visible = false;
            //    e.Row.Cells[3].Visible = false;
            //    e.Row.Cells[4].Visible = false;
        }

        protected void gridCastasVinho_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            //e.Row.Cells[0].Visible = false;
            //e.Row.Cells[2].Visible = false;
            //e.Row.Cells[4].Visible = false;
            //e.Row.Cells[5].Visible = false;
        }

        private void fillData(int idVinho)
        {
            DataTable table = Comentarios_Metodos.ComentarioSelect(idVinho);

            PagedDataSource pds = new PagedDataSource();
            DataView dv = new DataView(table);
            pds.DataSource = dv;
            pds.AllowPaging = true;
            pds.PageSize = 4;
            pds.CurrentPageIndex = PageNumber;
            if (pds.PageCount > 1)
            {
                rptPaging.Visible = true;
                ArrayList arraylist = new ArrayList();
                for (int i = 0; i < pds.PageCount; i++)
                    arraylist.Add((i + 1).ToString());
                rptPaging.DataSource = arraylist;
                rptPaging.DataBind();
            }
            else
            {
                rptPaging.Visible = false;
            }
            Repeater1.DataSource = pds;
            Repeater1.DataBind();
        }

        protected void btPostar_Click(object sender, EventArgs e)
        {
            int vinho = int.Parse(Request.QueryString["vinho"].ToString());

            int UtilizadorID = int.Parse(Session["id_utilizador"].ToString());


            Comentarios comentario = new Comentarios();
            comentario.UtilizadorID = UtilizadorID;
            comentario.VinhoID = vinho;
            comentario.Comentario = txComentario.Text;

            Comentarios_Metodos.Comentario_Insert(comentario);

            //Displaying Javascript alert Comment Posted Successfully
            ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "Alerta('O Comentário foi Postado com Sucesso!');window.location='Vinho.aspx';", true);

            fillData(vinho);
            txNomeUtilizador.Text = "";
            txComentario.Text = "";

        }
        public int PageNumber
        {
            get
            {
                if (ViewState["PageNumber"] != null)
                    return Convert.ToInt32(ViewState["PageNumber"]);
                else
                    return 0;
            }
            set
            {
                ViewState["PageNumber"] = value;
            }
        }

        protected void rptPaging_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int vinho = int.Parse(Request.QueryString["vinho"].ToString());
            PageNumber = Convert.ToInt32(e.CommandArgument) - 1;
            fillData(vinho);
        }

        protected void btFavorito_Click(object sender, EventArgs e)
        {

        }

        protected void ServerValidation(object source, ServerValidateEventArgs args)
        {
        }

        protected void imgFavorito_Click(object sender, ImageClickEventArgs e)
        {
            int vinhoId = int.Parse(Request.QueryString["vinho"].ToString());
            int UtilizadorID = int.Parse(Session["id_utilizador"].ToString());



            if (imgFavorito.DescriptionUrl == "Adicionar aos Favoritos")
            {
                Vinho_Metodos.AdicionarFavorito(vinhoId, UtilizadorID);
                ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "Alerta('O Comentário foi Postado com Sucesso!');window.location='Vinho.aspx';", true);
            }
            else if (imgFavorito.DescriptionUrl == "Remover dos Favoritos")
            {
                Vinho_Metodos.RemoverFavorito(vinhoId, UtilizadorID);
            }

            getFavorito();
        }
        #region Estrelas
        int getClassificacao()
        {
            int UtilizadorID = int.Parse(Session["id_utilizador"].ToString());
            int vinhoId = int.Parse(Request.QueryString["vinho"].ToString());


            int classificao = Comentarios_Metodos.MostrarPontuacao(vinhoId, UtilizadorID);
            if (classificao == 0)
            {
                estrela1.ImageUrl = "~/Imagens/Conteudo/Estrela-Vazia.png";
                estrela2.ImageUrl = "~/Imagens/Conteudo/Estrela-Vazia.png";
                estrela3.ImageUrl = "~/Imagens/Conteudo/Estrela-Vazia.png";
                estrela4.ImageUrl = "~/Imagens/Conteudo/Estrela-Vazia.png";
                estrela5.ImageUrl = "~/Imagens/Conteudo/Estrela-Vazia.png";
            }
            else if (classificao == 1)
            {
                estrela1.ImageUrl = "~/Imagens/Conteudo/Estrela-Amarela.png";
                estrela2.ImageUrl = "~/Imagens/Conteudo/Estrela-Vazia.png";
                estrela3.ImageUrl = "~/Imagens/Conteudo/Estrela-Vazia.png";
                estrela4.ImageUrl = "~/Imagens/Conteudo/Estrela-Vazia.png";
                estrela5.ImageUrl = "~/Imagens/Conteudo/Estrela-Vazia.png";
            }
            else if (classificao == 2)
            {
                estrela1.ImageUrl = "~/Imagens/Conteudo/Estrela-Amarela.png";
                estrela2.ImageUrl = "~/Imagens/Conteudo/Estrela-Amarela.png";
                estrela3.ImageUrl = "~/Imagens/Conteudo/Estrela-Vazia.png";
                estrela4.ImageUrl = "~/Imagens/Conteudo/Estrela-Vazia.png";
                estrela5.ImageUrl = "~/Imagens/Conteudo/Estrela-Vazia.png";
            }
            else if (classificao == 3)
            {
                estrela1.ImageUrl = "~/Imagens/Conteudo/Estrela-Amarela.png";
                estrela2.ImageUrl = "~/Imagens/Conteudo/Estrela-Amarela.png";
                estrela3.ImageUrl = "~/Imagens/Conteudo/Estrela-Amarela.png";
                estrela4.ImageUrl = "~/Imagens/Conteudo/Estrela-Vazia.png";
                estrela5.ImageUrl = "~/Imagens/Conteudo/Estrela-Vazia.png";
            }
            else if (classificao == 4)
            {
                estrela1.ImageUrl = "~/Imagens/Conteudo/Estrela-Amarela.png";
                estrela2.ImageUrl = "~/Imagens/Conteudo/Estrela-Amarela.png";
                estrela3.ImageUrl = "~/Imagens/Conteudo/Estrela-Amarela.png";
                estrela4.ImageUrl = "~/Imagens/Conteudo/Estrela-Amarela.png";
                estrela5.ImageUrl = "~/Imagens/Conteudo/Estrela-Vazia.png";
            }
            else if (classificao == 5)
            {
                estrela1.ImageUrl = "~/Imagens/Conteudo/Estrela-Amarela.png";
                estrela2.ImageUrl = "~/Imagens/Conteudo/Estrela-Amarela.png";
                estrela3.ImageUrl = "~/Imagens/Conteudo/Estrela-Amarela.png";
                estrela4.ImageUrl = "~/Imagens/Conteudo/Estrela-Amarela.png";
                estrela5.ImageUrl = "~/Imagens/Conteudo/Estrela-Amarela.png";
            }


            return classificao;
        }
        void getInserirClassificacao(int pontuacao)
        {
            int vinho = int.Parse(Request.QueryString["vinho"].ToString());

            int UtilizadorID = int.Parse(Session["id_utilizador"].ToString());


            Classificacao classificacao = new Classificacao();
            classificacao.UtilizadorID = UtilizadorID;
            classificacao.VinhoID = vinho;
            classificacao.Pontuacao = pontuacao;

            Comentarios_Metodos.Classificacao_Inserir(classificacao);

            if (pontuacao == 0)
            {
                estrela1.ImageUrl = "~/Imagens/Conteudo/Estrela-Vazia.png";
                estrela2.ImageUrl = "~/Imagens/Conteudo/Estrela-Vazia.png";
                estrela3.ImageUrl = "~/Imagens/Conteudo/Estrela-Vazia.png";
                estrela4.ImageUrl = "~/Imagens/Conteudo/Estrela-Vazia.png";
                estrela5.ImageUrl = "~/Imagens/Conteudo/Estrela-Vazia.png";
            }
            else if (pontuacao == 1)
            {
                estrela1.ImageUrl = "~/Imagens/Conteudo/Estrela-Amarela.png";
                estrela2.ImageUrl = "~/Imagens/Conteudo/Estrela-Vazia.png";
                estrela3.ImageUrl = "~/Imagens/Conteudo/Estrela-Vazia.png";
                estrela4.ImageUrl = "~/Imagens/Conteudo/Estrela-Vazia.png";
                estrela5.ImageUrl = "~/Imagens/Conteudo/Estrela-Vazia.png";
            }
            else if (pontuacao == 2)
            {
                estrela1.ImageUrl = "~/Imagens/Conteudo/Estrela-Amarela.png";
                estrela2.ImageUrl = "~/Imagens/Conteudo/Estrela-Amarela.png";
                estrela3.ImageUrl = "~/Imagens/Conteudo/Estrela-Vazia.png";
                estrela4.ImageUrl = "~/Imagens/Conteudo/Estrela-Vazia.png";
                estrela5.ImageUrl = "~/Imagens/Conteudo/Estrela-Vazia.png";
            }
            else if (pontuacao == 3)
            {
                estrela1.ImageUrl = "~/Imagens/Conteudo/Estrela-Amarela.png";
                estrela2.ImageUrl = "~/Imagens/Conteudo/Estrela-Amarela.png";
                estrela3.ImageUrl = "~/Imagens/Conteudo/Estrela-Amarela.png";
                estrela4.ImageUrl = "~/Imagens/Conteudo/Estrela-Vazia.png";
                estrela5.ImageUrl = "~/Imagens/Conteudo/Estrela-Vazia.png";
            }
            else if (pontuacao == 4)
            {
                estrela1.ImageUrl = "~/Imagens/Conteudo/Estrela-Amarela.png";
                estrela2.ImageUrl = "~/Imagens/Conteudo/Estrela-Amarela.png";
                estrela3.ImageUrl = "~/Imagens/Conteudo/Estrela-Amarela.png";
                estrela4.ImageUrl = "~/Imagens/Conteudo/Estrela-Amarela.png";
                estrela5.ImageUrl = "~/Imagens/Conteudo/Estrela-Vazia.png";
            }
            else if (pontuacao == 5)
            {
                estrela1.ImageUrl = "~/Imagens/Conteudo/Estrela-Amarela.png";
                estrela2.ImageUrl = "~/Imagens/Conteudo/Estrela-Amarela.png";
                estrela3.ImageUrl = "~/Imagens/Conteudo/Estrela-Amarela.png";
                estrela4.ImageUrl = "~/Imagens/Conteudo/Estrela-Amarela.png";
                estrela5.ImageUrl = "~/Imagens/Conteudo/Estrela-Amarela.png";
            }

            lbClassificacao.Text = Comentarios_Metodos.ClassificaçãoMedia(vinho).ToString() + " ☆";
        }

        protected void estrela1_Click(object sender, ImageClickEventArgs e)
        {
            int pontuacao = 1;

            getInserirClassificacao(pontuacao);
        }

        protected void estrela2_Click(object sender, ImageClickEventArgs e)
        {
            int pontuacao = 2;

            getInserirClassificacao(pontuacao);
        }

        protected void estrela3_Click(object sender, ImageClickEventArgs e)
        {
            int pontuacao = 3;

            getInserirClassificacao(pontuacao);
        }

        protected void estrela4_Click(object sender, ImageClickEventArgs e)
        {
            int pontuacao = 4;

            getInserirClassificacao(pontuacao);
        }

        protected void estrela5_Click(object sender, ImageClickEventArgs e)
        {
            int pontuacao = 5;

            getInserirClassificacao(pontuacao);
        }
        #endregion
    }
}