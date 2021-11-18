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
    public partial class Utilizadores : Form
    {
        public Utilizadores()
        {
            InitializeComponent();

        }
        int id;
        bool bloqueado = false;


        private void Utilizadores_Load(object sender, EventArgs e)
        {
            getUtilizadores();
        }

        void getUtilizadores()
        {
            bloqueado = false;
            BtBloquear.Text = "Bloquear";

            DataTable SelectUtilizadores = Utilizador_Metodos.UtilizadorSelect();

            gridUtilizadores.DataSource = SelectUtilizadores;

            gridUtilizadores.Columns[0].Visible = false;
            gridUtilizadores.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridUtilizadores.Columns[2].Visible = false;
            gridUtilizadores.Columns[3].Visible = false;
            gridUtilizadores.Columns[4].Visible = false;
            gridUtilizadores.Columns[5].Visible = false;

            gridUtilizadores.AllowUserToAddRows = false;
            gridUtilizadores.AllowUserToDeleteRows = false;
            gridUtilizadores.AllowUserToOrderColumns = false;
            gridUtilizadores.AllowUserToResizeColumns = false;
            gridUtilizadores.AllowUserToResizeRows = false;
            gridUtilizadores.RowHeadersVisible = false;
            gridUtilizadores.ReadOnly = true;
            gridUtilizadores.MultiSelect = false;
            gridUtilizadores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        void getUtilizadoresBloqueados()
        {
            bloqueado = true;
            BtBloquear.Text = "Desbloquear";

            DataTable SelectBloqueados = Utilizador_Metodos.UtilizadorSelectBloqueados();

            gridUtilizadores.DataSource = SelectBloqueados;

            gridUtilizadores.Columns[0].Visible = false;
            gridUtilizadores.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridUtilizadores.Columns[2].Visible = false;
            gridUtilizadores.Columns[3].Visible = false;
            gridUtilizadores.Columns[4].Visible = false;
            gridUtilizadores.Columns[5].Visible = false;

            gridUtilizadores.AllowUserToAddRows = false;
            gridUtilizadores.AllowUserToDeleteRows = false;
            gridUtilizadores.AllowUserToOrderColumns = false;
            gridUtilizadores.AllowUserToResizeColumns = false;
            gridUtilizadores.AllowUserToResizeRows = false;
            gridUtilizadores.RowHeadersVisible = false;
            gridUtilizadores.ReadOnly = true;
            gridUtilizadores.MultiSelect = false;
            gridUtilizadores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Utilizadores_Leave(object sender, EventArgs e)
        {
        }

        private void BtEditar_Click(object sender, EventArgs e)
        {
            int id = (int)gridUtilizadores.CurrentRow.Cells[0].Value;
            string nome = gridUtilizadores.CurrentRow.Cells[1].Value.ToString();

            if (gridUtilizadores.CurrentCell.RowIndex >= 0)
            {
                Utilizador editarUtilizador = new Utilizador();

                editarUtilizador.UtilizadorID = id;
                editarUtilizador.Nome = TxNomeUtilizador.Text;
                editarUtilizador.Descricao = TxDescricao.Text;
                editarUtilizador.Email = TxEmail.Text;
                editarUtilizador.DataNascimento = DateTime.Parse(DataNascimento.Value.ToString("dd/MM/yyyy"));

                Utilizador_Metodos.UtilizadorUpdate(editarUtilizador);

                MessageBox.Show("O Utilizador " + nome + " foi Editado com Sucesso!", "", MessageBoxButtons.OK);

                getUtilizadores();

                TxNomeUtilizador.Focus();
            }

        }

        private void picVinhao_Click(object sender, EventArgs e)
        {
        }

        private void gridUtilizadores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)gridUtilizadores.CurrentRow.Cells[0].Value;
            TxNomeUtilizador.Text = (gridUtilizadores.CurrentRow.Cells[1].Value).ToString();
            TxEmail.Text = (gridUtilizadores.CurrentRow.Cells[2].Value).ToString();
            DataNascimento.Value = Convert.ToDateTime(gridUtilizadores.CurrentRow.Cells[3].Value);
            TxDescricao.Text = (gridUtilizadores.CurrentRow.Cells[5].Value).ToString();
        }

        private void BtBloquear_Click(object sender, EventArgs e)
        {
            int id = (int)gridUtilizadores.CurrentRow.Cells[0].Value;
            string nome = gridUtilizadores.CurrentRow.Cells[1].Value.ToString();

            if (bloqueado == false)
            {
                DialogResult mensagem = MessageBox.Show("Tem a certeza que quer Bloquear o Utilizador " + nome + "?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (mensagem == DialogResult.Yes)
                {
                    if (gridUtilizadores.CurrentCell.RowIndex >= 0)
                    {
                        Utilizador eliminarUtilizador = new Utilizador();

                        eliminarUtilizador.UtilizadorID = id;

                        Utilizador_Metodos.UtilizadorDelete(eliminarUtilizador);
                        MessageBox.Show("O Utilizador " + nome + " foi Bloqueado com Sucesso!", "", MessageBoxButtons.OK);

                        getUtilizadores();

                        TxNomeUtilizador.Focus();
                    }
                }
            }
            else if (bloqueado == true)
            {
                DialogResult mensagem = MessageBox.Show("Tem a certeza que quer Desbloquear o Utilizador " + nome + "?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (mensagem == DialogResult.Yes)
                {
                    if (gridUtilizadores.CurrentCell.RowIndex >= 0)
                    {
                        Utilizador eliminarUtilizador = new Utilizador();

                        eliminarUtilizador.UtilizadorID = id;

                        Utilizador_Metodos.UtilizadorDesbloquear(eliminarUtilizador);

                        MessageBox.Show("O Utilizador " + nome + " foi Desbloqueado com Sucesso!", "", MessageBoxButtons.OK);

                        getUtilizadores();

                        TxNomeUtilizador.Focus();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getUtilizadores();
        }

        private void btUtilizadoresBloqueados_Click(object sender, EventArgs e)
        {
            getUtilizadoresBloqueados();
        }
    }
}

