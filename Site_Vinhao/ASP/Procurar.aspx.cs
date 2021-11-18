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
    public partial class Procurar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                getData();
            }

        }

        void getData()
        {
            cbRegiao.DataSource = Regiao_Metodos.RegiaoSelect();
            cbRegiao.DataTextField = "NomeRegiao";
            cbRegiao.DataValueField = "NomeRegiao";
            cbRegiao.DataBind();
            cbCasta.DataSource = Casta_Metodos.CastaSelect();
            cbCasta.DataTextField = "NomeCasta";
            cbCasta.DataValueField = "NomeCasta";
            cbCasta.DataBind();
            cbEnologo.DataSource = Enologo_Metodos.EnologoSelect();
            cbEnologo.DataTextField = "NomeEnologo";
            cbEnologo.DataValueField = "NomeEnologo";
            cbEnologo.DataBind();
            cbProdutor.DataSource = Produtor_Metodos.ProdutorSelect();
            cbProdutor.DataTextField = "NomeProdutor";
            cbProdutor.DataValueField = "NomeProdutor";
            cbProdutor.DataBind();
            cbTipo.DataSource = Tipo_Metodos.TipoSelect();
            cbTipo.DataTextField = "NomeTipo";
            cbTipo.DataValueField = "NomeTipo";
            cbTipo.DataBind();
        }

        void getVinho()
        {
            DataTable table = Vinho_Metodos.ProcurarNomeVinho(txProcurar.Text);

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

        void getUtilizador()
        {
            DataTable table = Vinho_Metodos.ProcurarUtilizador(txProcurar.Text);

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

        void getRegiao()
        {
            DataTable table = Vinho_Metodos.ProcurarRegiao(cbRegiao.SelectedValue);

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
        void getCasta()
        {
            DataTable table = Vinho_Metodos.ProcurarCasta(cbCasta.SelectedValue);

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
        void getEnologo()
        {
            DataTable table = Vinho_Metodos.ProcurarEnologo(cbEnologo.SelectedValue);

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
        void getProdutor()
        {
            DataTable table = Vinho_Metodos.ProcurarProdutor(cbProdutor.SelectedValue);

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

        void getTipo()
        {
            DataTable table = Vinho_Metodos.ProcurarTipo(cbTipo.SelectedValue);

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

        protected void btProcurar_Click(object sender, EventArgs e)
        {

        }

        protected void gridProcurar_SelectedIndexChanged(object sender, EventArgs e)
        {
        }



        protected void gridProcurar_RowDataBound(object sender, GridViewRowEventArgs e)
        {
        }

        protected void rptPaging_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            PageNumber = Convert.ToInt32(e.CommandArgument) - 1;
            getVinho();
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if (cbCategorias.SelectedValue == "0")
                getVinho();
            else if (cbCategorias.SelectedValue == "1")
                getUtilizador();
        }

        protected void cbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategorias.SelectedValue == "0" || cbCategorias.SelectedValue == "1")
            {
                txProcurar.Text = "";
                txProcurar.Visible = true;
                txProcurar.Enabled = true;
                txProcurar.ValidationGroup = "Validar";
                cbRegiao.Visible = false;
                cbRegiao.Enabled = false;
                cbCasta.Visible = false;
                cbCasta.Enabled = false;
                cbEnologo.Visible = false;
                cbEnologo.Enabled = false;
                cbProdutor.Visible = false;
                cbProdutor.Enabled = false;
                cbTipo.Visible = false;
                cbTipo.Enabled = false;

                btProcurarImg.Visible = true;
                btProcurarImg.Enabled = true;
                btProcurarImg2.Visible = false;
                btProcurarImg2.Enabled = false;
            }
            else if (cbCategorias.SelectedValue == "2")
            {
                txProcurar.Text = "";
                txProcurar.Visible = false;
                txProcurar.Enabled = false;
                txProcurar.ValidationGroup = "";
                cbRegiao.Visible = true;
                cbRegiao.Enabled = true;
                cbCasta.Visible = false;
                cbCasta.Enabled = false;
                cbEnologo.Visible = false;
                cbEnologo.Enabled = false;
                cbProdutor.Visible = false;
                cbProdutor.Enabled = false;
                cbTipo.Visible = false;
                cbTipo.Enabled = false;

                btProcurarImg.Visible = false;
                btProcurarImg.Enabled = false;
                btProcurarImg2.Visible = true;
                btProcurarImg2.Enabled = true;
            }
            else if (cbCategorias.SelectedValue == "3")
            {
                txProcurar.Text = "";
                txProcurar.Visible = false;
                txProcurar.Enabled = false;
                cbRegiao.Visible = false;
                cbRegiao.Enabled = false;
                cbCasta.Visible = true;
                cbCasta.Enabled = true;
                cbEnologo.Visible = false;
                cbEnologo.Enabled = false;
                cbProdutor.Visible = false;
                cbProdutor.Enabled = false;
                cbTipo.Visible = false;
                cbTipo.Enabled = false;

                btProcurarImg.Visible = false;
                btProcurarImg.Enabled = false;
                btProcurarImg2.Visible = true;
                btProcurarImg2.Enabled = true;
            }
            else if (cbCategorias.SelectedValue == "4")
            {
                txProcurar.Text = "";
                txProcurar.Visible = false;
                txProcurar.Enabled = false;
                cbRegiao.Visible = false;
                cbRegiao.Enabled = false;
                cbCasta.Visible = false;
                cbCasta.Enabled = false;
                cbEnologo.Visible = true;
                cbEnologo.Enabled = true;
                cbProdutor.Visible = false;
                cbProdutor.Enabled = false;
                cbTipo.Visible = false;
                cbTipo.Enabled = false;

                btProcurarImg.Visible = false;
                btProcurarImg.Enabled = false;
                btProcurarImg2.Visible = true;
                btProcurarImg2.Enabled = true;
            }
            else if (cbCategorias.SelectedValue == "5")
            {
                txProcurar.Text = "";
                txProcurar.Visible = false;
                txProcurar.Enabled = false;
                cbRegiao.Visible = false;
                cbRegiao.Enabled = false;
                cbCasta.Visible = false;
                cbCasta.Enabled = false;
                cbEnologo.Visible = false;
                cbEnologo.Enabled = false;
                cbProdutor.Visible = true;
                cbProdutor.Enabled = true;
                cbTipo.Visible = false;
                cbTipo.Enabled = false;

                btProcurarImg.Visible = false;
                btProcurarImg.Enabled = false;
                btProcurarImg2.Visible = true;
                btProcurarImg2.Enabled = true;
            }
            else if (cbCategorias.SelectedValue == "6")
            {
                txProcurar.Text = "";
                txProcurar.Visible = false;
                txProcurar.Enabled = false;
                cbRegiao.Visible = false;
                cbRegiao.Enabled = false;
                cbCasta.Visible = false;
                cbCasta.Enabled = false;
                cbEnologo.Visible = false;
                cbEnologo.Enabled = false;
                cbProdutor.Visible = false;
                cbProdutor.Enabled = false;
                cbTipo.Visible = true;
                cbTipo.Enabled = true;

                btProcurarImg.Visible = false;
                btProcurarImg.Enabled = false;
                btProcurarImg2.Visible = true;
                btProcurarImg2.Enabled = true;
            }
        }

        protected void cbCategorias_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btProcurarImg2_Click(object sender, ImageClickEventArgs e)
        {
            if (cbCategorias.SelectedValue == "2")
                getRegiao();
            else if (cbCategorias.SelectedValue == "3")
                getCasta();
            else if (cbCategorias.SelectedValue == "4")
                getEnologo();
            else if (cbCategorias.SelectedValue == "5")
                getProdutor();
            else if (cbCategorias.SelectedValue == "6")
                getTipo();
        }
    }
}