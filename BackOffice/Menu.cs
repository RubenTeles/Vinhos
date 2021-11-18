using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DALL;

namespace Vinhao_Aplicacao
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }


        public void Aparecer()
        {
            pictureVinhao.Visible = true;
            BtCastas.Visible = true;
            BtUtilizadores.Visible = true;
            BtVinhos.Visible = true;
            label4.Visible = true;
            lbUtilizadores.Visible = true;
            lbVinhos.Visible = true;
            lbCastas.Visible = true;
            picLogotipo.Visible = true;
            lbCountAprovar.Visible = true;
        }
        void Esconder()
        {
            pictureVinhao.Visible = false;
            BtCastas.Visible = false;
            BtUtilizadores.Visible = false;
            BtVinhos.Visible = false;
            label4.Visible = false;
            lbUtilizadores.Visible = false;
            lbVinhos.Visible = false;
            lbCastas.Visible = false;
            picLogotipo.Visible = false;
            lbCountAprovar.Visible = false;
        }

        void UtilizadoresForms()
        {
            Utilizadores u = new Utilizadores();
            u.MdiParent = this;
            u.WindowState = FormWindowState.Maximized;
            u.Show();
            Esconder();
        }
        void VinhosForms()
        {
            Vinhos v = new Vinhos();
            v.MdiParent = this;
            v.WindowState = FormWindowState.Maximized;
            v.Show();
            Esconder();
        }

        void CastasForms()
        {
            Castas c = new Castas();
            c.MdiParent = this;
            c.WindowState = FormWindowState.Maximized;
            c.Show();
            Esconder();
        }


        private void BtUtilizadores_Click(object sender, EventArgs e)
        {
            UtilizadoresForms();

        }

        private void lbUtilizadores_Click(object sender, EventArgs e)
        {
            UtilizadoresForms();
        }

        private void BtVinhos_Click(object sender, EventArgs e)
        {
            VinhosForms();
        }

        private void lbVinhos_Click(object sender, EventArgs e)
        {
            VinhosForms();
        }

        private void BtCastas_Click(object sender, EventArgs e)
        {
            CastasForms();
        }

        private void lbCastas_Click(object sender, EventArgs e)
        {
            CastasForms();
        }

        private void Menu_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
                Aparecer();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            picVinhao.Size = this.Size;

            int vinhosPorAprovar = Vinho_Metodos.MostrarVinhosPorAprovar();


            if (vinhosPorAprovar > 0)

                lbCountAprovar.Text = "Bem Vindo!\nTem " + vinhosPorAprovar.ToString() + " Vinhos por Aprovar.";
            else
                lbCountAprovar.Text = "Bem Vindo!\nNão existe nenhum Vinho por Aprovar.";



        }

        private void Menu_SizeChanged(object sender, EventArgs e)
        {
            this.Width = 666;
            this.Height = 419;
        }

        private void lbCountAprovar_Click(object sender, EventArgs e)
        {

        }
    }
}
