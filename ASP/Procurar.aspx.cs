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

        }

        void getProcurar2()
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
            //getProcurar();
            getProcurar2();
        }

        protected void gridProcurar_SelectedIndexChanged(object sender, EventArgs e)
        {
            //GridViewRow row = gridProcurar.SelectedRow;
            //string id = row.Cells[1].Text;



            //Response.Redirect("Vinho.aspx?vinho=" + id);


        }



        protected void gridProcurar_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            //e.Row.Cells[1].Visible = false;

        }

        protected void rptPaging_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            PageNumber = Convert.ToInt32(e.CommandArgument) - 1;
            getProcurar2();
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
          
        }
    }
}