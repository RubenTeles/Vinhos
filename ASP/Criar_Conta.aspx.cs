using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using DALL;

namespace Site_Vinhao
{
    public partial class Criar_Conta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string data = DateTime.Now.AddYears(-18).ToShortDateString();
                validarDataNascimento.ErrorMessage =
                "Defina data igual ou anterior a " + data;
                validarDataNascimento.Type = ValidationDataType.Date;
                validarDataNascimento.Operator = ValidationCompareOperator.LessThan;
                validarDataNascimento.ValueToCompare = data;

                //validarUsernameComparar.Type = ValidationDataType.String;
                //validarUsernameComparar.Operator = ValidationCompareOperator.Equal;
                //int valido = Utilizador_Metodos.ValidarNome(txUsername.Text);
                //if (valido == 1)
                //{
                //    validarUsernameComparar.ValueToCompare = "Ruben";//UserName Já Existente na Base de Dados.
                //}
                //else if (valido == 0)
                //{
                //    validarUsernameComparar.ValueToCompare = txUsername.Text;
                //}

            }
        }

        protected void btCriarConta_Click(object sender, EventArgs e)
        {
            //Criar conta – Memebership
            Membership.CreateUser(txUsername.Text, txPassword.Text, txEmail.Text);
            //obter o UserID
            MembershipUser user = Membership.GetUser(txUsername.Text);
            object user_id = user.ProviderUserKey;
            //Criar Utilizador (vinhos)
            Utilizador novoUtilizador = new Utilizador();
            novoUtilizador.Nome = txNome.Text;
            //novoUtilizador.Password = txPassword.Text;
            novoUtilizador.Email = txEmail.Text;
            novoUtilizador.DataNascimento = DateTime.Parse(txDatadeNascimento.Text);
            novoUtilizador.UserID = user_id.ToString();
            Utilizador_Metodos.UtilizadorInsert(novoUtilizador);
            Response.Redirect("Login.aspx");
        }
    }
}