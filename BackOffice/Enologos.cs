using DALL;
using System;
using System.Data;
using System.Windows.Forms;

namespace Vinhao_Aplicacao
{
    public partial class Enologos : Form
    {
        public Enologos()
        {
            InitializeComponent();
        }

        int id = -1;

        void getEnologo()
        {

            DataTable SelectEnologos = Enologo_Metodos.EnologoSelect();

            gridEnologos.DataSource = SelectEnologos;

            gridEnologos.Columns[0].Visible = false;
            gridEnologos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            gridEnologos.Columns[1].HeaderText = "Enologo";

            gridEnologos.AllowUserToAddRows = false;
            gridEnologos.AllowUserToDeleteRows = false;
            gridEnologos.AllowUserToOrderColumns = false;
            gridEnologos.AllowUserToResizeColumns = false;
            gridEnologos.AllowUserToResizeRows = false;
            gridEnologos.RowHeadersVisible = false;
            gridEnologos.ReadOnly = true;
            gridEnologos.MultiSelect = false;
            gridEnologos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (txtNomeEnologo.Text == "Escreva um novo Enologo" | txtNomeEnologo.Text == "")
            {
                MessageBox.Show("Escreva o Nome do Enologo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeEnologo.Focus();
            }
            else
            {
                if (gridEnologos.CurrentCell.RowIndex >= 0)
                {
                    Enologo editarEnologo = new Enologo();

                    editarEnologo.EnologoID = id;
                    editarEnologo.NomeEnologo = txtNomeEnologo.Text;

                    Enologo_Metodos.EnologoUpdate(editarEnologo);

                    MessageBox.Show("Foi Alterado com Sucesso!", "", MessageBoxButtons.OK);

                    getEnologo();

                    txtNomeEnologo.Focus();
                }
            }
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            if (txtNomeEnologo.Text == "Escreva um novo Enologo" | txtNomeEnologo.Text == "")
            {
                MessageBox.Show("Escreva o Nome do Enologo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeEnologo.Focus();
            }
            else
            {
                Enologo adicionarEnologo = new Enologo();

                adicionarEnologo.NomeEnologo = txtNomeEnologo.Text;

                Enologo_Metodos.EnologoInsert(adicionarEnologo);

                MessageBox.Show("Foi Adicionada com Sucesso!", "", MessageBoxButtons.OK);

                txtNomeEnologo.Text = "";

                getEnologo();

                txtNomeEnologo.Focus();
            }
        }


        private void Enologos_Load(object sender, EventArgs e)
        {
            getEnologo();
        }

        private void gridEnologos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)gridEnologos.CurrentRow.Cells[0].Value;
            txtNomeEnologo.Text = (gridEnologos.CurrentRow.Cells[1].Value).ToString();
        }

        private void txtNomeEnologo_Click(object sender, EventArgs e)
        {
            if (txtNomeEnologo.Text == "Escreva um novo Enologo")
                txtNomeEnologo.Text = "";
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            int id = (int)gridEnologos.CurrentRow.Cells[0].Value;
            string nome = gridEnologos.CurrentRow.Cells[1].Value.ToString();

            DialogResult mensagem = MessageBox.Show("Tem a certeza que quer Eliminar o Enologo " + nome + "?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (mensagem == DialogResult.Yes)
            {
                if (gridEnologos.CurrentCell.RowIndex >= 0)
                {
                    Enologo eliminarEnologo = new Enologo();

                    eliminarEnologo.EnologoID = id;

                    Enologo_Metodos.EnologoDelete(eliminarEnologo);
                    MessageBox.Show("O Enologo " + nome + " foi Eliminada com Sucesso!", "", MessageBoxButtons.OK);

                    getEnologo();

                    txtNomeEnologo.Focus();
                }
            }
        }
    }
}
