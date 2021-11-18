using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using DALL;

namespace Site_Vinhao.ASP
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginUtilizador_LoggedIn(object sender, EventArgs e)
        {
            //Validar utilizador - Memebership
            MembershipUser user = Membership.GetUser(loginUtilizador.UserName);
            //Obter ID (chave primária - Utilizador) e colocar em Session
            Session["id_utilizador"] = Utilizador_Metodos.UtilizadorObterID(user.ProviderUserKey.ToString());
            Response.Redirect("~/ASP/Perfil.aspx");
        }
    }
}