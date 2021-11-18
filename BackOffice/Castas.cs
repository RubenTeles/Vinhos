using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DALL;

namespace Vinhao_Aplicacao
{
    public partial class Castas : Form
    {
        public Castas()
        {
            InitializeComponent();
        }

        int id = -1;


        private void Castas_Load(object sender, EventArgs e)
        {
            getCastas();
        }

        void getCastas()
        {

            DataTable SelectCastas = Casta_Metodos.CastaSelect();

            gridCastas.DataSource = SelectCastas;

            gridCastas.Columns[0].Visible = false;
            gridCastas.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridCastas.Columns[2].Visible = false;


            gridCastas.Columns[1].HeaderText = "Casta";

            gridCastas.AllowUserToAddRows = false;
            gridCastas.AllowUserToDeleteRows = false;
            gridCastas.AllowUserToOrderColumns = false;
            gridCastas.AllowUserToResizeColumns = false;
            gridCastas.AllowUserToResizeRows = false;
            gridCastas.RowHeadersVisible = false;
            gridCastas.ReadOnly = true;
            gridCastas.MultiSelect = false;
            gridCastas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void TxNomeCasta_Click(object sender, EventArgs e)
        {
            if (txNomeCasta.Text == "Nome da Casta")
                txNomeCasta.Text = "";
        }


        private void TxDescricao_Click(object sender, EventArgs e)
        {
            if (txDescricao.Text == "Região, Produtor, etc...")
                txDescricao.Text = "";
        }

        private void BtAdicionar_Click(object sender, EventArgs e)
        {
            if (txNomeCasta.Text == "Nome da Casta" || txNomeCasta.Text == "")
            {
                MessageBox.Show("Escreva o Nome da Casta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txNomeCasta.Focus();
            }
            else if (txDescricao.Text == "Região, Produtor, etc..." || txDescricao.Text == "")
            {
                MessageBox.Show("Escreva uma Descrição", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txDescricao.Focus();
            }
            else
            {
                Casta novaCasta = new Casta();

                novaCasta.NomeCasta = txNomeCasta.Text;
                novaCasta.DescricaoCasta = txDescricao.Text;

                Casta_Metodos.CastaInsert(novaCasta);

                MessageBox.Show("Foi Adicionada com Sucesso, uma Nova Casta à Base de Dados!", "", MessageBoxButtons.OK);

                txNomeCasta.Text = "";
                txDescricao.Text = "";

                getCastas();

                txNomeCasta.Focus();
            }
        }
        private void gridCastas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)gridCastas.CurrentRow.Cells[0].Value;
            txNomeCasta.Text = (gridCastas.CurrentRow.Cells[1].Value).ToString();
            txDescricao.Text = (gridCastas.CurrentRow.Cells[2].Value).ToString();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            int id = (int)gridCastas.CurrentRow.Cells[0].Value;

            if (txNomeCasta.Text == "Nome da Casta" || txNomeCasta.Text == "")
            {
                MessageBox.Show("Escreva o Nome da Casta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txNomeCasta.Focus();
            }
            else if (txDescricao.Text == "Região, Produtor, etc..." || txDescricao.Text == "")
            {
                MessageBox.Show("Escreva uma Descrição", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txDescricao.Focus();
            }
            else
            {
                if (gridCastas.CurrentCell.RowIndex >= 0)
                {
                    Casta editarCasta = new Casta();

                    editarCasta.CastaID = id;
                    editarCasta.NomeCasta = txNomeCasta.Text;
                    editarCasta.DescricaoCasta = txDescricao.Text;

                    Casta_Metodos.CastaUpdate(editarCasta);
                    MessageBox.Show("Foi Alterada com Sucesso!", "", MessageBoxButtons.OK);

                    getCastas();

                    txNomeCasta.Focus();
                }
            }
        }

        private void picVinhao_Click(object sender, EventArgs e)
        {

        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            int id = (int)gridCastas.CurrentRow.Cells[0].Value;
            string nome = gridCastas.CurrentRow.Cells[1].Value.ToString();

            DialogResult mensagem = MessageBox.Show("Tem a certeza que quer Eliminar a Casta " + nome + "?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (mensagem == DialogResult.Yes)
            {
                if (gridCastas.CurrentCell.RowIndex >= 0)
                {
                    Casta eliminarcasta = new Casta();

                    eliminarcasta.CastaID = id;

                    Casta_Metodos.CastaDelete(eliminarcasta);
                    MessageBox.Show("A Casta " + nome + " foi Eliminada com Sucesso!", "", MessageBoxButtons.OK);

                    getCastas();

                    txNomeCasta.Focus();
                }
            }
        }
    }
}
