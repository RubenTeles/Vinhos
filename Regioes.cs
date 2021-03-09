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
    public partial class Regioes : Form
    {
        public Regioes()
        {
            InitializeComponent();
        }

        int id = -1;

        void getRegiao()
        {

            DataTable SelectRegioes = Regiao_Metodos.RegiaoSelect();

            gridRegioes.DataSource = SelectRegioes;

            gridRegioes.Columns[0].Visible = false;
            gridRegioes.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            gridRegioes.Columns[1].HeaderText = "Região";

            gridRegioes.AllowUserToAddRows = false;
            gridRegioes.AllowUserToDeleteRows = false;
            gridRegioes.AllowUserToOrderColumns = false;
            gridRegioes.AllowUserToResizeColumns = false;
            gridRegioes.AllowUserToResizeRows = false;
            gridRegioes.RowHeadersVisible = false;
            gridRegioes.ReadOnly = true;
            gridRegioes.MultiSelect = false;
            gridRegioes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void gridRegioes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)gridRegioes.CurrentRow.Cells[0].Value;
            txtNomeRegiao.Text = (gridRegioes.CurrentRow.Cells[1].Value).ToString();
        }

        private void Regioes_Load(object sender, EventArgs e)
        {
            getRegiao();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            if (txtNomeRegiao.Text == "Escreva uma nova Região" | txtNomeRegiao.Text == "")
            {
                MessageBox.Show("Escreva o Nome da Região", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeRegiao.Focus();
            }
            else
            {
                Regiao novaRegiao = new Regiao();

                novaRegiao.NomeRegiao = txtNomeRegiao.Text;

                Regiao_Metodos.RegiaoInsert(novaRegiao);

                MessageBox.Show("Foi Adicionado com Sucesso, uma Nova Região à Base de Dados!", "", MessageBoxButtons.OK);

                txtNomeRegiao.Text = "";

                getRegiao();
                txtNomeRegiao.Focus();
            }

        }

        private void txtNomeRegiao_Click(object sender, EventArgs e)
        {
            if (txtNomeRegiao.Text == "Escreva uma nova Região")
                txtNomeRegiao.Text = "";
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (txtNomeRegiao.Text == "Escreva uma nova Região" | txtNomeRegiao.Text == "")
            {
                MessageBox.Show("Escreva o Nome da Região", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeRegiao.Focus();
            }
            else
            {
                if (gridRegioes.CurrentCell.RowIndex >= 0)
                {
                    Regiao editarRegiao = new Regiao();

                    editarRegiao.RegiaoID = id;
                    editarRegiao.NomeRegiao = txtNomeRegiao.Text;

                    Regiao_Metodos.RegiaoUpdate(editarRegiao);

                    MessageBox.Show("Foi Alterada com Sucesso!", "", MessageBoxButtons.OK);

                    getRegiao();
                    txtNomeRegiao.Focus();
                }
            }

        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            int id = (int)gridRegioes.CurrentRow.Cells[0].Value;
            string nome = gridRegioes.CurrentRow.Cells[1].Value.ToString();

            DialogResult mensagem = MessageBox.Show("Tem a certeza que quer Eliminar a Região " + nome + "?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (mensagem == DialogResult.Yes)
            {
                if (gridRegioes.CurrentCell.RowIndex >= 0)
                {
                    Regiao eliminarRegiao = new Regiao();

                    eliminarRegiao.RegiaoID = id;

                    Regiao_Metodos.RegiaoDelete(eliminarRegiao);
                    MessageBox.Show("A Região " + nome + " foi Eliminada com Sucesso!", "", MessageBoxButtons.OK);

                    getRegiao();

                    txtNomeRegiao.Focus();
                }
            }
        }
    }
}
