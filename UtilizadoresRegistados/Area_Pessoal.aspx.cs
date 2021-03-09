using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DALL;

namespace Site_Vinhao.UtilizadoresRegistados
{
    public partial class Area_Pessoal : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            int UtilizadorID = getUser();

            getSeusVinhos(UtilizadorID);
            getFavoritos(UtilizadorID);
            getPorAprovar(UtilizadorID);
        }

        int getUser()
        {
            int UtilizadorID = -1;
            try
            {
                string UserID = Session["id_utilizador"].ToString();
                UtilizadorID = int.Parse(Utilizador_Metodos.UtilizadorObterID(UserID));
                string nome = Utilizador_Metodos.UtilizadorObterNome(UtilizadorID);
                lbNome.Text = nome;


            }
            catch (Exception)
            {

                UtilizadorID = int.Parse(Session["id_utilizador"].ToString());
                string nome = Utilizador_Metodos.UtilizadorObterNome(UtilizadorID);
                lbNome.Text = nome;

            }

            return UtilizadorID;
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
        protected void Repeater2_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            PageNumber1 = Convert.ToInt32(e.CommandArgument) - 1;
            getSeusVinhos(getUser());
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
        protected void Repeater3_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }

        protected void rptPaging3_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            PageNumber3 = Convert.ToInt32(e.CommandArgument) - 1;
            getPorAprovar(getUser());
        }

        protected void rptPaging2_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            PageNumber2 = Convert.ToInt32(e.CommandArgument) - 1;
            getFavoritos(getUser());
        }

        protected void rptPaging1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }
    }
}