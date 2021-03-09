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
    public partial class Tipos : Form
    {
        public Tipos()
        {
            InitializeComponent();
        }

        int id = -1;

        void getTipo()
        {


            DataTable SelectTipo = Tipo_Metodos.TipoSelect();

            gridTipo.DataSource = SelectTipo;

            gridTipo.Columns[0].Visible = false;
            gridTipo.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            gridTipo.Columns[1].HeaderText = "Tipo";

            gridTipo.AllowUserToAddRows = false;
            gridTipo.AllowUserToDeleteRows = false;
            gridTipo.AllowUserToOrderColumns = false;
            gridTipo.AllowUserToResizeColumns = false;
            gridTipo.AllowUserToResizeRows = false;
            gridTipo.RowHeadersVisible = false;
            gridTipo.ReadOnly = true;
            gridTipo.MultiSelect = false;
            gridTipo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        private void Tipos_Load(object sender, EventArgs e)
        {
            getTipo();
        }

        private void gridTipo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)gridTipo.CurrentRow.Cells[0].Value;
            txtNomeTipo.Text = (gridTipo.CurrentRow.Cells[1].Value).ToString();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            if (txtNomeTipo.Text == "Escreva um Tipo" | txtNomeTipo.Text == "")
            {
                MessageBox.Show("Escreva o Nome do Produtor", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeTipo.Focus();
            }

            else
            {
                Tipo adicionarTipo = new Tipo();

                adicionarTipo.NomeTipo = txtNomeTipo.Text;

                Tipo_Metodos.TipoInsert(adicionarTipo);

                MessageBox.Show("Foi Adicionado com Sucesso!", "", MessageBoxButtons.OK);

                txtNomeTipo.Text = "";

                getTipo();
                txtNomeTipo.Focus();
            }
        }

        private void txtNomeTipo_Click(object sender, EventArgs e)
        {
            if (txtNomeTipo.Text == "Escreva um Tipo")
                txtNomeTipo.Text = "";
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (txtNomeTipo.Text == "Escreva um Tipo" | txtNomeTipo.Text == "")
            {
                MessageBox.Show("Escreva o Nome do Produtor", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeTipo.Focus();
            }
            else
            {
                if (gridTipo.CurrentCell.RowIndex >= 0)
                {
                    Tipo editarTipo = new Tipo();

                    editarTipo.TipoID = id;
                    editarTipo.NomeTipo = txtNomeTipo.Text;

                    Tipo_Metodos.TipoUpdate(editarTipo);

                    MessageBox.Show("Foi Alterado com Sucesso!", "", MessageBoxButtons.OK);

                    getTipo();
                    txtNomeTipo.Focus();
                }
            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            int id = (int)gridTipo.CurrentRow.Cells[0].Value;
            string nome = gridTipo.CurrentRow.Cells[1].Value.ToString();

            DialogResult mensagem = MessageBox.Show("Tem a certeza que quer Eliminar o Tipo de Vinho " + nome + "?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (mensagem == DialogResult.Yes)
            {
                if (gridTipo.CurrentCell.RowIndex >= 0)
                {
                    Tipo eliminarTipo = new Tipo();

                    eliminarTipo.TipoID = id;

                    Tipo_Metodos.TipoDelete(eliminarTipo);
                    MessageBox.Show("O Tipo de Vinho " + nome + " foi Eliminada com Sucesso!", "", MessageBoxButtons.OK);

                    getTipo();

                    txtNomeTipo.Focus();
                }
            }
        }
    }
}
