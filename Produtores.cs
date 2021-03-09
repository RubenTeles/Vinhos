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
    public partial class Produtores : Form
    {
        public Produtores()
        {
            InitializeComponent();
        }

        int id = -1;

        void getProdutor()
        {

            DataTable SelectProdutor = Produtor_Metodos.ProdutorSelect();

            gridProdutores.DataSource = SelectProdutor;

            gridProdutores.Columns[0].Visible = false;
            gridProdutores.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridProdutores.Columns[2].Visible = false;


            gridProdutores.Columns[1].HeaderText = "Produtor";

            gridProdutores.AllowUserToAddRows = false;
            gridProdutores.AllowUserToDeleteRows = false;
            gridProdutores.AllowUserToOrderColumns = false;
            gridProdutores.AllowUserToResizeColumns = false;
            gridProdutores.AllowUserToResizeRows = false;
            gridProdutores.RowHeadersVisible = false;
            gridProdutores.ReadOnly = true;
            gridProdutores.MultiSelect = false;
            gridProdutores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


        }

        private void Produtores_Load(object sender, EventArgs e)
        {
            getProdutor();
        }

        private void gridProdutores_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            id = (int)gridProdutores.CurrentRow.Cells[0].Value;
            txtProdutor.Text = (gridProdutores.CurrentRow.Cells[1].Value).ToString();
            txtURL.Text = (gridProdutores.CurrentRow.Cells[2].Value).ToString();
        }

        private void txtNomeEnologo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomeEnologo_Click(object sender, EventArgs e)
        {
            if (txtProdutor.Text == "Escreva um novo Produtor")
                txtProdutor.Text = "";
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (txtURL.Text == "Escreva o URL")
                txtURL.Text = "";
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            if (txtProdutor.Text == "Escreva um novo Produtor" | txtProdutor.Text == "")
            {
                MessageBox.Show("Escreva o Nome do Produtor", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProdutor.Focus();
            }
            else if (txtURL.Text == "Escreva o URL" | txtProdutor.Text == "")
            {
                MessageBox.Show("Escreva o URL", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtURL.Focus();
            }
            else
            {
                Produtor adicionarProdutor = new Produtor();

                adicionarProdutor.NomeProdutor = txtProdutor.Text;
                adicionarProdutor.URL = txtURL.Text;

                Produtor_Metodos.ProdutorInsert(adicionarProdutor);

                MessageBox.Show("Foi Adicionado com Sucesso!", "", MessageBoxButtons.OK);

                txtProdutor.Text = "";
                txtURL.Text = "";

                getProdutor();
                txtProdutor.Focus();
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (txtProdutor.Text == "Escreva um novo Produtor" | txtProdutor.Text == "")
            {
                MessageBox.Show("Escreva o Nome do Produtor", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProdutor.Focus();
            }
            else if (txtURL.Text == "Escreva o URL" | txtProdutor.Text == "")
            {
                MessageBox.Show("Escreva o URL", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtURL.Focus();
            }
            else
            {
                if (gridProdutores.CurrentCell.RowIndex >= 0)
                {
                    Produtor editarProdutor = new Produtor();

                    editarProdutor.ProdutorID = id;
                    editarProdutor.NomeProdutor = txtProdutor.Text;
                    editarProdutor.URL = txtURL.Text;

                    Produtor_Metodos.ProdutorUpdate(editarProdutor);

                    MessageBox.Show("Foi Alterado com Sucesso!", "", MessageBoxButtons.OK);

                    getProdutor();

                    txtProdutor.Focus();
                }
            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            int id = (int)gridProdutores.CurrentRow.Cells[0].Value;
            string nome = gridProdutores.CurrentRow.Cells[1].Value.ToString();

            DialogResult mensagem = MessageBox.Show("Tem a certeza que quer Eliminar o Produtor " + nome + "?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (mensagem == DialogResult.Yes)
            {
                if (gridProdutores.CurrentCell.RowIndex >= 0)
                {
                    Produtor eliminarProdutor = new Produtor();

                    eliminarProdutor.ProdutorID = id;

                    Produtor_Metodos.ProdutorDelete(eliminarProdutor);
                    MessageBox.Show("O Produtor " + nome + " foi Eliminada com Sucesso!", "", MessageBoxButtons.OK);

                    getProdutor();

                    txtProdutor.Focus();
                }
            }
        }
    }
}
