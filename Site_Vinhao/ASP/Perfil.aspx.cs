using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DALL;

namespace Site_Vinhao.ASP
{
    public partial class Perfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int UilizadorID = getUser();


            if (!IsPostBack)
            {
                string data = DateTime.Now.AddYears(-18).ToShortDateString();
                validarDataNascimento.ErrorMessage =
                "Defina data igual ou anterior a " + data;
                validarDataNascimento.Type = ValidationDataType.Date;
                validarDataNascimento.Operator = ValidationCompareOperator.LessThan;
                validarDataNascimento.ValueToCompare = data;



                int utilizador = -1;

                if (Request.QueryString["utilizador"] != null)
                    utilizador = int.Parse(Request.QueryString["utilizador"].ToString());

                if (utilizador == -1)
                {
                    try
                    {
                        try
                        {
                            string UserID = Session["id_utilizador"].ToString();
                            utilizador = int.Parse(Utilizador_Metodos.UtilizadorObterID(UserID));
                        }
                        catch (Exception)
                        {
                            utilizador = int.Parse(Session["id_utilizador"].ToString());
                        }

                    }
                    catch (Exception)
                    {
                        //Caso não seja Utilizador Registado
                        utilizador = -1;

                        Response.Redirect("~/ASP/Home.aspx");
                    }
                }


                if (utilizador != -1)
                    getPerfil(utilizador);


                if (UilizadorID > 0 && UilizadorID != utilizador)//Caso seja Utilizador Registado
                {
                    btEditar.Visible = false;
                }
                else if (UilizadorID < 0) //Caso não seja Utilizador Registado
                {
                    btEditar.Visible = false;
                }
                else if (UilizadorID == utilizador)//Caso seja Utilizador do Perfil
                {
                    btEditar.Visible = true;
                    btEditarDataNascimento.Visible = true;
                    btEditarDescricao.Visible = true;
                    btEditarEmail.Visible = true;
                    btEditarImagem.Visible = true;
                    MudarPassword.Visible = true;
                    vinhos_por_aprovar.Visible = true;
                    lbEmail.Visible = true;
                    Label5.Visible = true;
                }


                getSeusVinhos(utilizador);
                getFavoritos(utilizador);
                getPorAprovar(utilizador);

            }
        }
        int getUser()
        {
            int UtilizadorID = 0;
            try
            {
                try
                {
                    string UserID = Session["id_utilizador"].ToString();
                    UtilizadorID = int.Parse(Utilizador_Metodos.UtilizadorObterID(UserID));
                }
                catch (Exception)
                {
                    UtilizadorID = int.Parse(Session["id_utilizador"].ToString());
                }

            }
            catch (Exception)
            {
                //Caso não seja Utilizador Registado

                UtilizadorID = -1;
            }


            return UtilizadorID;
        }

        void getPerfil(int utilizador)
        {
            int id = utilizador;

            gridPerfil.DataSource = Utilizador_Metodos.Select_Perfil(utilizador);
            gridPerfil.DataBind();

            gridPerfil.SelectRow(0);

            GridViewRow row = gridPerfil.SelectedRow;

            id = int.Parse(row.Cells[0].Text);
            lbNomeUtilizador.Text = row.Cells[1].Text;
            lbDescricao.Text = row.Cells[2].Text;
            foto.ImageUrl = row.Cells[3].Text;
            lbDataNascimento.Text = row.Cells[4].Text;
            lbCriado.Text = row.Cells[5].Text;
            lbUltimaEntrada.Text = row.Cells[6].Text;
            lbnumeroVinhos.Text = row.Cells[7].Text;
            lbnumeroFavoritos.Text = row.Cells[8].Text;
            lbnumeroComentarios.Text = row.Cells[9].Text;
            lbnumeroClassificados.Text = row.Cells[10].Text;
            lbEmail.Text = row.Cells[11].Text;
            lbnumeroPorAprovar.Text = row.Cells[12].Text;

            txNome.Text = row.Cells[1].Text;
            txtDescricao.Text = row.Cells[2].Text;

        }
        void getSeusVinhos(int UtilizadorID)
        {
            DataTable table = Utilizador_Metodos.VinhoSelectByUtilizadorID(UtilizadorID);

            PagedDataSource pds = new PagedDataSource();
            DataView dv = new DataView(table);
            pds.DataSource = dv;
            pds.AllowPaging = true;
            pds.PageSize = 4;
            pds.CurrentPageIndex = PageNumber1;
            if (pds.PageCount > 1)
            {
                rptPaging1.Visible = true;
                ArrayList arraylist = new ArrayList();
                for (int i = 0; i < pds.PageCount; i++)
                    arraylist.Add((i + 1).ToString());
                rptPaging1.DataSource = arraylist;
                rptPaging1.DataBind();
            }
            else
            {
                rptPaging1.Visible = false;
            }
            Repeater1.DataSource = pds;
            Repeater1.DataBind();
        }
        public int PageNumber1
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

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }

        protected void rptPaging1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            PageNumber1 = Convert.ToInt32(e.CommandArgument) - 1;
            getSeusVinhos(getUser());
        }

        void getFavoritos(int UtilizadorID)
        {
            DataTable table = Utilizador_Metodos.VinhoSelectByFavorito(UtilizadorID);

            PagedDataSource pds = new PagedDataSource();
            DataView dv = new DataView(table);
            pds.DataSource = dv;
            pds.AllowPaging = true;
            pds.PageSize = 4;
            pds.CurrentPageIndex = PageNumber2;
            if (pds.PageCount > 1)
            {
                rptPaging2.Visible = true;
                ArrayList arraylist = new ArrayList();
                for (int i = 0; i < pds.PageCount; i++)
                    arraylist.Add((i + 1).ToString());
                rptPaging2.DataSource = arraylist;
                rptPaging2.DataBind();
            }
            else
            {
                rptPaging2.Visible = false;
            }
            Repeater2.DataSource = pds;
            Repeater2.DataBind();
        }
        public int PageNumber2
        {
            get
            {
                if (ViewState["PageNumber2"] != null)
                    return Convert.ToInt32(ViewState["PageNumber2"]);
                else
                    return 0;
            }
            set
            {
                ViewState["PageNumber2"] = value;
            }
        }

        protected void rptPaging2_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            PageNumber2 = Convert.ToInt32(e.CommandArgument) - 1;
            getFavoritos(getUser());
        }

        protected void gridPerfil_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }

        void getPorAprovar(int UtilizadorID)
        {
            DataTable table = Utilizador_Metodos.VinhoSelectByUtilizadorIDPorAprovar(UtilizadorID);

            PagedDataSource pds = new PagedDataSource();
            DataView dv = new DataView(table);
            pds.DataSource = dv;
            pds.AllowPaging = true;
            pds.PageSize = 4;
            pds.CurrentPageIndex = PageNumber3;
            if (pds.PageCount > 1)
            {
                rptPaging3.Visible = true;
                ArrayList arraylist = new ArrayList();
                for (int i = 0; i < pds.PageCount; i++)
                    arraylist.Add((i + 1).ToString());
                rptPaging3.DataSource = arraylist;
                rptPaging3.DataBind();
            }
            else
            {
                rptPaging3.Visible = false;
            }
            Repeater3.DataSource = pds;
            Repeater3.DataBind();
        }
        public int PageNumber3
        {
            get
            {
                if (ViewState["PageNumber3"] != null)
                    return Convert.ToInt32(ViewState["PageNumber3"]);
                else
                    return 0;
            }
            set
            {
                ViewState["PageNumber3"] = value;
            }
        }
        protected void rptPaging3_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            PageNumber3 = Convert.ToInt32(e.CommandArgument) - 1;
            getPorAprovar(getUser());
        }

        protected void btEditar_Click(object sender, ImageClickEventArgs e)
        {
            if (txNome.Visible == true)
            {
                txNome.Visible = false;
                txNome.Enabled = false;
                btEditar.ImageUrl = "~/Imagens/Conteudo/settings.png";
                btCruzNome.Visible = false;

                int utilizador = int.Parse(Session["id_utilizador"].ToString());

                Utilizador update = new Utilizador();

                update.Nome = txNome.Text;
                update.UtilizadorID = utilizador;

                Utilizador_Metodos.UtilizadorUpdateNome(update);

                getPerfil(utilizador);
            }

            else if (txNome.Visible == false)
            {
                txNome.Visible = true;
                txNome.Enabled = true;
                btEditar.ImageUrl = "~/Imagens/Conteudo/certo.png";
                btCruzNome.Visible = true;
            }

        }
        protected void btCruzNome_Click(object sender, ImageClickEventArgs e)
        {
            txNome.Visible = false;
            txNome.Enabled = false;
            btEditar.ImageUrl = "~/Imagens/Conteudo/settings.png";
            btCruzNome.Visible = false;
        }
        protected void btEditarPerfil_Click(object sender, EventArgs e)
        {

        }

        protected void btEditarEmail_Click(object sender, ImageClickEventArgs e)
        {
            if (txEmail.Visible == true)
            {
                txEmail.Visible = false;
                txEmail.Enabled = false;
                btEditarEmail.ImageUrl = "~/Imagens/Conteudo/settings.png";
                btCruzEmail.Visible = false;

                int utilizador = int.Parse(Session["id_utilizador"].ToString());

                Utilizador update = new Utilizador();

                update.Email = txEmail.Text;
                update.UtilizadorID = utilizador;

                Utilizador_Metodos.UtilizadorUpdateEmail(update);

                getPerfil(utilizador);
            }

            else if (txEmail.Visible == false)
            {
                txEmail.Visible = true;
                txEmail.Enabled = true;
                btEditarEmail.ImageUrl = "~/Imagens/Conteudo/certo.png";
                btCruzEmail.Visible = true;
            }

        }
        protected void btCruzEmail_Click(object sender, ImageClickEventArgs e)
        {
            txEmail.Visible = false;
            txEmail.Enabled = false;
            btEditarEmail.ImageUrl = "~/Imagens/Conteudo/settings.png";
            btCruzEmail.Visible = false;
        }
        protected void btEditarDataNascimento_Click(object sender, ImageClickEventArgs e)
        {
            if (txDatadeNascimento.Visible == true)
            {
                txDatadeNascimento.Visible = false;
                txDatadeNascimento.Enabled = false;
                btEditarDataNascimento.ImageUrl = "~/Imagens/Conteudo/settings.png";
                btCruzDataNascimento.Visible = false;

                int utilizador = int.Parse(Session["id_utilizador"].ToString());

                Utilizador update = new Utilizador();

                update.DataNascimento = DateTime.Parse(txDatadeNascimento.Text);
                update.UtilizadorID = utilizador;

                Utilizador_Metodos.UtilizadorUpdateDataNascimento(update);

                getPerfil(utilizador);
            }

            else if (txDatadeNascimento.Visible == false)
            {
                txDatadeNascimento.Visible = true;
                txDatadeNascimento.Enabled = true;
                btEditarDataNascimento.ImageUrl = "~/Imagens/Conteudo/certo.png";
                btCruzDataNascimento.Visible = true;
            }
        }
        protected void btCruzDataNascimento_Click(object sender, ImageClickEventArgs e)
        {
            txDatadeNascimento.Visible = false;
            txDatadeNascimento.Enabled = false;
            btEditarDataNascimento.ImageUrl = "~/Imagens/Conteudo/settings.png";
            btCruzDataNascimento.Visible = false;
        }
        protected void btEditarImagem_Click(object sender, ImageClickEventArgs e)
        {

            if (updateFoto.Visible == true)
            {
                updateFoto.Visible = false;
                updateFoto.Enabled = false;
                btEditarImagem.ImageUrl = "~/Imagens/Conteudo/settings.png";
                btCruzFoto.Visible = false;

                int utilizador = int.Parse(Session["id_utilizador"].ToString());

                Utilizador update = new Utilizador();

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

                update.UtilizadorID = utilizador;

                Utilizador_Metodos.UtilizadorUpdateFoto(update);

                getPerfil(utilizador);
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
        protected void btEditarDescricao_Click(object sender, ImageClickEventArgs e)
        {
            if (txtDescricao.Visible == true)
            {
                txtDescricao.Visible = false;
                txtDescricao.Enabled = false;
                btEditarDescricao.ImageUrl = "~/Imagens/Conteudo/settings.png";
                btCruzDescricao.Visible = false;

                int utilizador = int.Parse(Session["id_utilizador"].ToString());

                Utilizador update = new Utilizador();

                update.Descricao = txtDescricao.Text;
                update.UtilizadorID = utilizador;

                Utilizador_Metodos.UtilizadorUpdateDescricao(update);

                getPerfil(utilizador);
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






    }
}
