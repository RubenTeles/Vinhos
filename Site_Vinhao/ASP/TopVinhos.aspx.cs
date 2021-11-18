using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DALL;

namespace Site_Vinhao.ASP
{
    public partial class TopVinhos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            getVinho();
        }
        void getVinho()
        {
            Repeater1.DataSource = Comentarios_Metodos.ClassificacaoSelectTop5();

            Repeater1.DataBind();
        }
    }
}