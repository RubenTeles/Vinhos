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

                if (user == true && UtilizadorID != id)//Caso seja o Utilizador que Postou o Vinho
                {
                    txNomeComentario.ReadOnly = true;
                    btFavorito.Visible = true;
                    getFavorito();
                }
                else
                {
                    fazercomentario.Visible = false;
                    btFavorito.Visible = false;
                }
            }
        }



        int getVinho(int vinho)
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
            int id = int.Parse(row.Cells[16].Text);
            txUtilizador.Text = row.Cells[17].Text;

            gridCastasVinho.DataSource = CastasVinhos_Metodos.VerCastasdoVinhos(vinho);
            gridCastasVinho.DataBind();


            gridEnologosVinho.DataSource = EnologosVinhos_Metodos.VerEnologosdoVinhos(vinho);
            gridEnologosVinho.DataBind();

            lbClassificacao.Text = Comentarios_Metodos.ClassificaçãoMedia(vinho).ToString();


            return id;
        }

        int getFavorito()
        {
            int UtilizadorID = int.Parse(Session["id_utilizador"].ToString());
            int vinhoId = int.Parse(Request.QueryString["vinho"].ToString());


            int favorito = Vinho_Metodos.MostrarSeEFavorito(vinhoId, UtilizadorID);
            if (favorito > 0)
            {
                btFavorito.Text = "Remover dos Favoritos";
            }
            else if (favorito == 0)
            {
                btFavorito.Text = "Adicionar aos Favoritos";
            }

            return favorito;
        }

        protected void btEnviar_Click(object sender, EventArgs e)
        {

        }

        protected void gridEnologosVinho_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[0].Visible = false;
            e.Row.Cells[1].Visible = false;
            e.Row.Cells[3].Visible = false;
            e.Row.Cells[4].Visible = false;
        }

        protected void gridCastasVinho_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[0].Visible = false;
            e.Row.Cells[2].Visible = false;
            e.Row.Cells[4].Visible = false;
            e.Row.Cells[5].Visible = false;
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
            comentario.Classificacao = int.Parse(txClassificacao.Text);

            Comentarios_Metodos.Comentario_Insert(comentario);

            //Displaying Javascript alert Comment Posted Successfully
            ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "Alerta('O Comentário foi Postado com Sucesso!');window.location='Vinho.aspx';", true);

            fillData(vinho);
            txNome.Text = "";
            txClassificacao.Text = "";
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
            int vinhoId = int.Parse(Request.QueryString["vinho"].ToString());
            int UtilizadorID = int.Parse(Session["id_utilizador"].ToString());



            if (btFavorito.Text == "Adicionar aos Favoritos")
            {
                Vinho_Metodos.AdicionarFavorito(vinhoId, UtilizadorID);
                ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "Alerta('O Comentário foi Postado com Sucesso!');window.location='Vinho.aspx';", true);
            }
            else if (btFavorito.Text == "Remover dos Favoritos")
            {
                Vinho_Metodos.RemoverFavorito(vinhoId, UtilizadorID);
            }

            getFavorito();
        }

        protected void ServerValidation(object source, ServerValidateEventArgs args)
        {
        }
    }
}