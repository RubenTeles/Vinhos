using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vinhao_Aplicacao
{
    public partial class Capa : Form
    {
        public Capa()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Cardapio C = new Cardapio();
            C.Show();
        }

        private void Capa_Load(object sender, EventArgs e)
        {

        }
    }
}
