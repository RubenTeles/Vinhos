using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DALL;

namespace Vinhao_Aplicacao
{
    public partial class Cardapio : Form
    {
        public Cardapio()
        {
            InitializeComponent();
        }

        private void Carpario_Load(object sender, EventArgs e)
        {
            int vinhosPorAprovar = Vinho_Metodos.MostrarVinhosPorAprovar();
            
            string vinhosPorAprovarString = "";

            if (vinhosPorAprovar > 0)
                vinhosPorAprovarString = "Tem " + vinhosPorAprovar.ToString() + " Vinhos por Aprovar.";
            else if (vinhosPorAprovar == 0)
                vinhosPorAprovarString = "Não existe nenhum Vinho por Aprovar.";

            int numeroDeVinhos = Vinho_Metodos.NumeroDeVinhos();
            string numeroDeVinhosString = "Tem " + numeroDeVinhos.ToString() + " Vinhos.";

            int numeroDeUtilizadores = Utilizador_Metodos.MostrarNumeroUtilizadores();
            string numeroDeUtilizadoresString = "Tem " + numeroDeUtilizadores.ToString() + " Utilizadores.";


            lbCountAprovar.Text = "Bem Vindo!\n" + vinhosPorAprovarString + "\n" + numeroDeVinhosString + "\n" + numeroDeUtilizadoresString;


        }

        private void lbUtilizadores_Click(object sender, EventArgs e)
        {
            Utilizadores u = new Utilizadores();
            u.Show();
        }

        private void lbCastas_Click(object sender, EventArgs e)
        {
            Castas C = new Castas();
            C.Show();
        }

        private void lbRegiao_Click(object sender, EventArgs e)
        {
            Regioes r = new Regioes();
            r.Show();
        }

        private void lbEnologo_Click(object sender, EventArgs e)
        {
            Enologos en = new Enologos();
            en.Show();
        }

        private void lbProdutor_Click(object sender, EventArgs e)
        {
            Produtores p = new Produtores();
            p.Show();
        }

        private void lbTipo_Click(object sender, EventArgs e)
        {
            Tipos t = new Tipos();
            t.Show();
        }

        private void lbCountAprovar_Click(object sender, EventArgs e)
        {

        }

        private void lbAdicionarVinhos_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            Vinhos v = new Vinhos();
            v.Show();
        }
    }
}
