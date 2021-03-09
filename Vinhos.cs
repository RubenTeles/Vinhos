using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DALL;
using Microsoft.VisualBasic;

namespace Vinhao_Aplicacao
{
    public partial class Vinhos : Form
    {
        public Vinhos()
        {
            InitializeComponent();
        }

        bool aprovar = false;


        private void Vinhos_Load(object sender, EventArgs e)
        {
            PreencherData();
            getVinhos();
        }
        void getVinhos()
        {
            label4.Text = "Adicionar Vinhos";
            btAprovarTudo.Visible = false;
            BtAdicionar.Text = "Adicionar";
            lbVinhosPorAprovar.Text = "";

            aprovar = false;

            DataTable SelectVinhos = Vinho_Metodos.VinhoSelect();

            gridVinho.DataSource = SelectVinhos;

            gridVinho.Columns[0].Visible = false;
            gridVinho.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridVinho.Columns[2].Visible = false;
            gridVinho.Columns[3].Visible = false;
            gridVinho.Columns[4].Visible = false;
            gridVinho.Columns[5].Visible = false;
            gridVinho.Columns[6].Visible = false;
            gridVinho.Columns[7].Visible = false;
            gridVinho.Columns[8].Visible = false;
            gridVinho.Columns[9].Visible = false;
            gridVinho.Columns[10].Visible = false;
            gridVinho.Columns[11].Visible = false;
            gridVinho.Columns[12].Visible = false;
            gridVinho.Columns[13].Visible = false;
            gridVinho.Columns[14].Visible = false;
            gridVinho.Columns[15].Visible = false;
            gridVinho.Columns[16].Visible = false;
            gridVinho.Columns[17].Visible = false;


            gridVinho.AllowUserToAddRows = false;
            gridVinho.AllowUserToDeleteRows = false;
            gridVinho.AllowUserToOrderColumns = false;
            gridVinho.AllowUserToResizeColumns = false;
            gridVinho.AllowUserToResizeRows = false;
            gridVinho.RowHeadersVisible = false;
            gridVinho.ReadOnly = true;
            gridVinho.MultiSelect = false;
            gridVinho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            Inicio();
        }

        void getVinhosPorAprovar()
        {
            int vinhosPorAprovar = Vinho_Metodos.MostrarVinhosPorAprovar();

            if (vinhosPorAprovar > 0)
            {
                aprovar = true;

                lbVinhosPorAprovar.Text = "Vinhos Por Aprovar: " + vinhosPorAprovar;
                btAprovarTudo.Visible = true;
                BtAdicionar.Text = "Aprovar";

                label4.Text = "Vinhos Por Aprovar";



                DataTable SelectVinhos = Vinho_Metodos.SelectVinhosPorAprovar();

                gridVinho.DataSource = SelectVinhos;

                gridVinho.Columns[0].Visible = false;
                gridVinho.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gridVinho.Columns[2].Visible = false;
                gridVinho.Columns[3].Visible = false;
                gridVinho.Columns[4].Visible = false;
                gridVinho.Columns[5].Visible = false;
                gridVinho.Columns[6].Visible = false;
                gridVinho.Columns[7].Visible = false;
                gridVinho.Columns[8].Visible = false;
                gridVinho.Columns[9].Visible = false;
                gridVinho.Columns[10].Visible = false;
                gridVinho.Columns[11].Visible = false;
                gridVinho.Columns[12].Visible = false;
                gridVinho.Columns[13].Visible = false;
                gridVinho.Columns[14].Visible = false;
                gridVinho.Columns[15].Visible = false;
                gridVinho.Columns[16].Visible = false;
                gridVinho.Columns[17].Visible = false;


                gridVinho.AllowUserToAddRows = false;
                gridVinho.AllowUserToDeleteRows = false;
                gridVinho.AllowUserToOrderColumns = false;
                gridVinho.AllowUserToResizeColumns = false;
                gridVinho.AllowUserToResizeRows = false;
                gridVinho.RowHeadersVisible = false;
                gridVinho.ReadOnly = true;
                gridVinho.MultiSelect = false;
                gridVinho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                Inicio();
            }
            else
            {
                MessageBox.Show("Não Existe Vinhos por Aprovar!", "Alerta!");
                getVinhos();
            }
        }
        void PreencherData()
        {
            cbProdutor.DataSource = Produtor_Metodos.ProdutorSelect();
            cbProdutor.DisplayMember = "NomeProdutor";
            cbProdutor.ValueMember = "ProdutorID";

            CbTipo.DataSource = Tipo_Metodos.TipoSelect();
            CbTipo.DisplayMember = "NomeTipo";
            CbTipo.ValueMember = "TipoID";

            CbRegiao.DataSource = Regiao_Metodos.RegiaoSelect();
            CbRegiao.DisplayMember = "NomeRegiao";
            CbRegiao.ValueMember = "IDRegiao";

            cbUtilizador.DataSource = Utilizador_Metodos.UtilizadorSelect();
            cbUtilizador.DisplayMember = "Nome";
            cbUtilizador.ValueMember = "UtilizadorID";

            lbxCastas.DataSource = Casta_Metodos.CastaSelect();
            lbxCastas.DisplayMember = "NomeCasta";
            lbxCastas.ValueMember = "IdCastas";

            lbxEnologos.DataSource = Enologo_Metodos.EnologoSelect();
            lbxEnologos.DisplayMember = "NomeEnologo";
            lbxEnologos.ValueMember = "EnologoID";
        }

        private void Vinhos_Leave(object sender, EventArgs e)
        {

        }

        private void BtAceitar_Click(object sender, EventArgs e)
        {
            if (aprovar == false)
            {
                Vinho adicionarVinho = new Vinho();

                adicionarVinho.NomeVinho = txNomeVinho.Text;
                adicionarVinho.Descricao = txDescricao.Text;
                adicionarVinho.UtilizadorID = (int)cbUtilizador.SelectedValue;
                adicionarVinho.Foto = txFoto.Text;
                adicionarVinho.Ano = int.Parse(txAno.Text);
                adicionarVinho.Volume = decimal.Parse(txVolume.Text);
                adicionarVinho.TeorAlcoolico = decimal.Parse(txTeorAlcoolico.Text);
                adicionarVinho.Temperatura = txTempura.Text;
                adicionarVinho.RegiaoID = (int)CbRegiao.SelectedValue;
                adicionarVinho.ProdutorID = (int)cbProdutor.SelectedValue;
                adicionarVinho.TipoID = (int)CbTipo.SelectedValue;

                int idVinho = int.Parse(Vinho_Metodos.VinhoInsert(adicionarVinho));

                Foto(idVinho);
                string foto = txFoto.Text;

                Vinho_Metodos.UpdateFoto(idVinho, foto);

                bool enologoaceite = AdicionarEnologo(idVinho);

                int castaaceite = AdicionarCasta(idVinho);
                while (castaaceite == 0)
                {
                    MessageBox.Show("Adicione uma Casta ao Vinho " + txNomeVinho.Text + "!", "Atenção!");
                    castaaceite = AdicionarCasta(idVinho);
                }

                if (enologoaceite == true && castaaceite > 0)
                    MessageBox.Show("Foi Adicionado um Novo Vinho!", "Parabens!");

                getVinhos();
            }
            else if (aprovar == true)
            {
                Vinho aprovarVinho = new Vinho();

                aprovarVinho.NomeVinho = txNomeVinho.Text;
                aprovarVinho.Descricao = txDescricao.Text;
                aprovarVinho.UtilizadorID = (int)cbUtilizador.SelectedValue;
                aprovarVinho.Foto = txFoto.Text;
                aprovarVinho.Ano = int.Parse(txAno.Text);
                aprovarVinho.Volume = decimal.Parse(txVolume.Text);
                aprovarVinho.TeorAlcoolico = decimal.Parse(txTeorAlcoolico.Text);
                aprovarVinho.Temperatura = txTempura.Text;
                aprovarVinho.RegiaoID = (int)CbRegiao.SelectedValue;
                aprovarVinho.ProdutorID = (int)cbProdutor.SelectedValue;
                aprovarVinho.TipoID = (int)CbTipo.SelectedValue;

                Vinho_Metodos.VinhoAprovar(aprovarVinho);

                MessageBox.Show("O Vinho " + txNomeVinho.Text + " foi Aprovado com Sucesso!", "Atenção!");

                getVinhosPorAprovar();
            }
        }

        bool AdicionarEnologo(int idVinho)
        {
            //---Enologos
            bool enologoaceite = false;

            if (lbxEnologos.Items.Count > 0)
            {
                for (int i = 0; i < lbxEnologos.Items.Count; i++)
                {
                    if (lbxEnologos.GetSelected(i) == true)
                    {
                        DataRowView drv = (DataRowView)lbxEnologos.Items[i];
                        int valor = (int)drv.Row["EnologoID"];
                        EnologosVinhos novoEnologo = new EnologosVinhos();
                        novoEnologo.EnologoID = valor;
                        novoEnologo.VinhoID = idVinho;

                        EnologosVinhos_Metodos.EnologosInsert(novoEnologo);

                    }

                    enologoaceite = true;
                }

            }
            return enologoaceite;
        }

        int AdicionarCasta(int idVinho)
        {
            //--Castas

            string mensagem = "a1";
            int casta = 0;

            if (lbxCastas.Items.Count > 0)
            {
                for (int i = 0; i < lbxCastas.Items.Count; i++)
                {
                    if (lbxCastas.GetSelected(i) == true)
                    {
                        DataRowView drv = (DataRowView)lbxCastas.Items[i];
                        int valor = (int)drv.Row["IdCastas"];
                        string nome = drv.Row["NomeCasta"].ToString();

                        bool aceite = false;
                        decimal percentagem = 0;

                        do
                        {
                            do
                            {

                                mensagem = Interaction.InputBox("Qual é a Percentagem da Casta " + nome, "Percentagem", "", -1, -1);

                                mensagem.Replace(",", ".");
                                if (mensagem != "")//Caso a Interaction Seja Cancelada!
                                {
                                    if (decimal.TryParse(mensagem, out percentagem))
                                    {
                                    }
                                    else
                                    {
                                        mensagem = "a1";
                                        MessageBox.Show("O formato que escreveu não é em percentagem.\nEscreva algo como '22,23'", "Alerta!");
                                    }
                                }


                            } while (mensagem == "a1");

                            if (mensagem != "")//Caso a Interaction Seja Cancelada!
                            {
                                if (txPercentagem.Text == "")
                                {
                                    txPercentagem.Text = "0";
                                    lbPercentagem.Text = "Percentagem\nTotal:";
                                }

                                decimal percentagemTotal = decimal.Parse(txPercentagem.Text);

                                if ((percentagemTotal + percentagem) <= 100)
                                {
                                    aceite = true;

                                    CastasVinhos novaCasta = new CastasVinhos();
                                    novaCasta.CastaID = valor;
                                    novaCasta.VinhoID = idVinho;
                                    novaCasta.Percentagem = percentagem;

                                    txPercentagem.Text = CastasVinhos_Metodos.InserirCastasVinhos(novaCasta).ToString();

                                    ++casta;
                                }
                                else if ((percentagemTotal + percentagem) > 100)
                                {
                                    aceite = false;

                                    MessageBox.Show("A percentagem da excede o Limite!\nPor Favor coloque um numero até " + (100 - percentagemTotal), "Alerta!");

                                }

                            }
                            else if (mensagem == "")
                            {
                                MessageBox.Show("A Casta " + nome + " foi Eliminada!", "Atenção!");
                                aceite = true;
                            }

                        } while (aceite == false);



                    }
                }

            }
            return casta;
        }

        void Foto(int vinhosID)
        {
            if (foto.Image != null)
            {
                //Eliminar imagem da pasta antes de guardar nova imagem

                string solutionDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
                var filePath = solutionDirectory + @"\Site_Vinhao\Imagens\" + vinhosID + ".jpg";

                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
                foto.Image.Save(filePath);
                txFoto.Text = @"\Site_Vinhao\Imagens\" + vinhosID + ".jpg";
            }
            else
                txFoto.Text = labelImagem.Text;


        }
        private void btFoto_Click(object sender, EventArgs e)
        {
            Image File;
            OpenFileDialog f = new OpenFileDialog();

            f.Filter = "Image files (*.jpg; *.jpeg; *.bmp; *.png)|*.jpg; *.jpeg; *.bmp; *.png";
            f.Multiselect = false;

            if (f.ShowDialog() == DialogResult.OK)
            {
                File = Image.FromFile(f.FileName);
                foto.Image = File;
                labelImagem.Text = "Foi adicionado com Sucesso";
                txFoto.Text = f.FileName;
            }
            else
            {
                labelImagem.Visible = true;
                labelImagem.Text = "Formato Inválido!";
            }
        }

        private void BtEditar_Click(object sender, EventArgs e)
        {
            if (gridVinho.CurrentCell.RowIndex >= 0)
            {
                int id = (int)gridVinho.CurrentRow.Cells[0].Value;

                Foto(id);

                Vinho editarVinho = new Vinho();

                editarVinho.VinhoID = id;
                editarVinho.NomeVinho = txNomeVinho.Text;
                editarVinho.Descricao = txDescricao.Text;
                editarVinho.UtilizadorID = (int)cbUtilizador.SelectedValue;
                editarVinho.Foto = txFoto.Text;
                editarVinho.Ano = int.Parse(txAno.Text);
                editarVinho.Volume = decimal.Parse(txVolume.Text);
                editarVinho.TeorAlcoolico = decimal.Parse(txTeorAlcoolico.Text);
                editarVinho.Temperatura = txTempura.Text;
                editarVinho.RegiaoID = (int)CbRegiao.SelectedValue;
                editarVinho.ProdutorID = (int)cbProdutor.SelectedValue;
                editarVinho.TipoID = (int)CbTipo.SelectedValue;

                Vinho_Metodos.VinhoUpdate(editarVinho);

                MessageBox.Show("O Vinho " + txNomeVinho.Text + " foi Editado com Sucesso!", "Atenção!");

                if (aprovar == false)
                    getVinhos();
                else if (aprovar == true)
                    getVinhosPorAprovar();
            }
        }
        private void btEliminar_Click(object sender, EventArgs e)
        {
            int vinhoID = (int)gridVinho.CurrentRow.Cells[0].Value;
            string vinho = gridVinho.CurrentRow.Cells[1].Value.ToString();


            DialogResult mensagem = MessageBox.Show("Deseja Eliminar o Vinho " + vinho + "?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (mensagem == DialogResult.Yes)
            {
                Vinho_Metodos.VinhoDelete(vinhoID);
                MessageBox.Show("O Vinho " + vinho + " foi Eliminado com Sucesso!", "Atenção!");

                if (aprovar == false)
                {
                    getVinhos();
                }
                else if (aprovar == true)
                {
                    getVinhosPorAprovar();
                }
            }
        }

        private void picVinhao_Click(object sender, EventArgs e)
        {

        }

        private void PicFolhaMaisCastas_Click(object sender, EventArgs e)
        {

        }

        private void PicFolhaMaisRegiao_Click(object sender, EventArgs e)
        {

        }

        private void gridVinho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txNomeVinho.Text = gridVinho.CurrentRow.Cells[1].Value.ToString();
            txDescricao.Text = gridVinho.CurrentRow.Cells[2].Value.ToString();
            foto.ImageLocation = gridVinho.CurrentRow.Cells[4].Value.ToString();
            txFoto.Text = gridVinho.CurrentRow.Cells[4].Value.ToString();
            txAno.Text = gridVinho.CurrentRow.Cells[5].Value.ToString();
            txVolume.Text = gridVinho.CurrentRow.Cells[6].Value.ToString();
            txTeorAlcoolico.Text = gridVinho.CurrentRow.Cells[7].Value.ToString();
            txTempura.Text = gridVinho.CurrentRow.Cells[8].Value.ToString();
            CbTipo.Text = gridVinho.CurrentRow.Cells[10].Value.ToString();
            CbRegiao.Text = gridVinho.CurrentRow.Cells[12].Value.ToString();
            cbProdutor.Text = gridVinho.CurrentRow.Cells[14].Value.ToString();
            cbUtilizador.Text = gridVinho.CurrentRow.Cells[17].Value.ToString();

            PreencherEditar();
        }

        void Inicio()
        {
            BtEditar.Visible = false;
            btEliminar.Visible = false;
            btEditarCasta.Visible = false;
            btEliminarCasta.Visible = false;
            btElimanarEnologo.Visible = false;
            txPercentagem.ReadOnly = true;
            btTrocarCastas1.Visible = false;
            btTrocarEnologo1.Visible = false;
            groupBoxCastas.Visible = false;
            groupBoxEnologos.Visible = false;
            lbPercentagem.Visible = false;
            lbxCastas.SelectionMode = SelectionMode.MultiSimple;
            lbxEnologos.SelectionMode = SelectionMode.MultiSimple;
            //cbUtilizador.Enabled = false;

            txNomeVinho.Text = "";
            txDescricao.Text = "";
            txFoto.Text = "";
            txAno.Text = "";
            txVolume.Text = "";
            txTeorAlcoolico.Text = "";
            txTempura.Text = "";

            PreencherData();
        }

        void PreencherEditar()
        {
            btNovoVinho.Visible = true;
            BtEditar.Visible = true;
            btEliminar.Visible = true;
            btEditarCasta.Visible = true;
            btEliminarCasta.Visible = true;
            btElimanarEnologo.Visible = true;
            txPercentagem.ReadOnly = false;
            btTrocarCastas1.Visible = true;
            btTrocarEnologo1.Visible = true;
            lbxCastasPercentagem.Visible = true;
            groupBoxCastas.Visible = true;
            groupBoxCastas.Text = "Editar Castas";
            groupBoxEnologos.Visible = true;
            groupBoxEnologos.Text = "Eliminar Enologos";
            lbPercentagem.Visible = true;
            lbxCastas.SelectionMode = SelectionMode.One;
            lbPercentagem.Text = "Nova\nPercentagem:";
            lbxEnologos.SelectionMode = SelectionMode.One;

            int idvinho = (int)gridVinho.CurrentRow.Cells[0].Value;

            lbxCastas.DataSource = CastasVinhos_Metodos.VerCastasdoVinhos(idvinho);
            lbxCastas.DisplayMember = "NomeCasta";
            lbxCastas.ValueMember = "IdCastas";

            lbxCastasPercentagem.DataSource = CastasVinhos_Metodos.VerCastasdoVinhos(idvinho);
            lbxCastasPercentagem.DisplayMember = "Percentagem";
            lbxCastasPercentagem.ValueMember = "Percentagem";


            lbxEnologos.DataSource = EnologosVinhos_Metodos.VerEnologosdoVinhos(idvinho);
            lbxEnologos.DisplayMember = "NomeEnologo";
            lbxEnologos.ValueMember = "EnologoID";


        }
               
        private void btTrocarCastas_Click(object sender, EventArgs e)
        {
            btTrocarCastas1.Visible = false;
            btTrocarCastas2.Visible = true;
            btAdicionarCasta.Visible = true;
            btEditarCasta.Visible = false;
            btEliminarCasta.Visible = false;
            label19.Visible = false;
            lbxCastasPercentagem.Visible = false;
            groupBoxCastas.Text = "Adicionar Castas"; 
            txPercentagem.ReadOnly = true;
            lbxCastas.SelectionMode = SelectionMode.MultiSimple;
            lbPercentagem.Text = "Percentagem\nTotal:";

            int idvinho = (int)gridVinho.CurrentRow.Cells[0].Value;
            lbxCastas.DataSource = CastasVinhos_Metodos.RestantesCastasdoVinhos(idvinho);
            lbxCastas.DisplayMember = "NomeCasta";
            lbxCastas.ValueMember = "IdCastas";

            lbxCastasPercentagem.Visible = false;

            

            txPercentagem.Text = CastasVinhos_Metodos.VerPercentagemTotal(idvinho).ToString();
        }

        private void btTrocarCastas2_Click(object sender, EventArgs e)
        {
            btTrocarCastas1.Visible = true;
            btTrocarCastas2.Visible = false;
            btAdicionarCasta.Visible = false;
            btEditarCasta.Visible = true;
            btEliminarCasta.Visible = true;
            lbxCastasPercentagem.Visible = true;
            lbPercentagem.Visible = true;
            groupBoxCastas.Text = "Editar Castas";
            txPercentagem.ReadOnly = false;
            lbxCastas.SelectionMode = SelectionMode.One;
            lbPercentagem.Text = "\nPercentagem:";




            int idvinho = (int)gridVinho.CurrentRow.Cells[0].Value;

            lbxCastas.DataSource = CastasVinhos_Metodos.VerCastasdoVinhos(idvinho);
            lbxCastas.DisplayMember = "NomeCasta";
            lbxCastas.ValueMember = "IdCastas";

            lbxCastasPercentagem.DataSource = CastasVinhos_Metodos.VerCastasdoVinhos(idvinho);
            lbxCastasPercentagem.DisplayMember = "Percentagem";
            lbxCastasPercentagem.ValueMember = "Percentagem";

            txPercentagem.Text = CastasVinhos_Metodos.VerPercentagemTotal(idvinho).ToString();
        }

        private void btEditarCasta_Click(object sender, EventArgs e)
        {
            if (lbxCastas.Items.Count > 0)
            {
                for (int i = 0; i < lbxCastas.Items.Count; i++)
                {
                    if (lbxCastas.GetSelected(i) == true)
                    {
                        decimal percentagem = 0;

                        DataRowView drv = (DataRowView)lbxCastas.Items[i];
                        int idCastaVinho = (int)drv.Row["IdCastas_Vinho"];
                        string casta = drv.Row["NomeCasta"].ToString();
                        int idCasta = (int)drv.Row["IdCastas"];
                        int idVinhos = (int)drv.Row["IdVinho"];
                        if (decimal.TryParse(txPercentagem.Text, out percentagem))
                        {
                            decimal percentagemTotal = CastasVinhos_Metodos.VerPercentagemTotal(idVinhos);
                            if ((percentagemTotal + percentagem) <= 100)
                            {
                                DialogResult mensagem = MessageBox.Show("Deseja Editar a Casta " + casta + "?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                                if (mensagem == DialogResult.Yes)
                                {
                                    CastasVinhos_Metodos.CastaVinhosUpdate(idCastaVinho, idVinhos, idCasta, percentagem);
                                    PreencherEditar();
                                }

                            }
                            else if ((percentagemTotal + percentagem) > 100)
                            {

                                MessageBox.Show("A percentagem da excede o Limite!\nPor Favor coloque um numero até " + (100 - percentagemTotal), "Alerta!");

                            }
                        }
                        else
                        {
                            MessageBox.Show("O formato que escreveu não é em percentagem.\nEscreva algo como '22,23'", "Alerta!");
                        }
                    }
                }
            }
        }
        private void btEliminarCasta_Click(object sender, EventArgs e)
        {
            if (lbxCastas.Items.Count > 0)
            {
                for (int i = 0; i < lbxCastas.Items.Count; i++)
                {
                    if (lbxCastas.GetSelected(i) == true)
                    {
                        DataRowView drv = (DataRowView)lbxCastas.Items[i];
                        int idCastaVinho = (int)drv.Row["IdCastas_Vinho"];
                        string casta = drv.Row["NomeCasta"].ToString();

                        DialogResult mensagem = MessageBox.Show("Deseja Eliminar a Casta " + casta + "?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (mensagem == DialogResult.Yes)
                        {
                            CastasVinhos_Metodos.RemoverCasta(idCastaVinho);
                            PreencherEditar();
                        }
                    }
                }
            }


        }
        private void btTrocarEnologo_Click(object sender, EventArgs e)
        {
            btTrocarEnologo1.Visible = false;
            btTrocarEnologo2.Visible = true;
            btAdicionarEnologo.Visible = true;
            btElimanarEnologo.Visible = false;
            groupBoxEnologos.Text = "Adicionar Enologos";

            lbxCastas.SelectionMode = SelectionMode.MultiSimple;

            int idvinho = (int)gridVinho.CurrentRow.Cells[0].Value;
            lbxEnologos.DataSource = EnologosVinhos_Metodos.RestantesEnologosdoVinhos(idvinho);
            lbxEnologos.DisplayMember = "NomeEnologo";
            lbxEnologos.ValueMember = "EnologoID";

        }

        private void btTrocarEnologo2_Click(object sender, EventArgs e)
        {
            btTrocarEnologo1.Visible = true;
            btTrocarEnologo2.Visible = false;
            btAdicionarEnologo.Visible = false;
            btElimanarEnologo.Visible = true;
            groupBoxEnologos.Text = "Eliminar Enologos";
            lbxEnologos.SelectionMode = SelectionMode.One;

            int idvinho = (int)gridVinho.CurrentRow.Cells[0].Value;

            lbxEnologos.DataSource = EnologosVinhos_Metodos.VerEnologosdoVinhos(idvinho);
            lbxEnologos.DisplayMember = "NomeEnologo";
            lbxEnologos.ValueMember = "EnologoID";

        }

        private void btEditarEnologo_Click(object sender, EventArgs e)
        {
            //Não Existe
        }

        private void btElimanarEnologo_Click(object sender, EventArgs e)
        {
            if (lbxEnologos.Items.Count > 0)
            {
                for (int i = 0; i < lbxEnologos.Items.Count; i++)
                {
                    if (lbxEnologos.GetSelected(i) == true)
                    {
                        DataRowView drv = (DataRowView)lbxEnologos.Items[i];
                        int idEnologoVinhos = (int)drv.Row["Enologo_VinhosID"];
                        string enologo = drv.Row["NomeEnologo"].ToString();

                        DialogResult mensagem = MessageBox.Show("Deseja Eliminar o Enologo " + enologo + "?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (mensagem == DialogResult.Yes)
                        {
                            EnologosVinhos_Metodos.RemoverEnologo(idEnologoVinhos);
                        }
                    }
                }
            }
            PreencherEditar();
        }

        private void btAdicionarCasta_Click(object sender, EventArgs e)
        {
            int idVinho = (int)gridVinho.CurrentRow.Cells[0].Value;
            DataRowView drv = (DataRowView)lbxCastas.Items[0];
            string casta = drv.Row["NomeCasta"].ToString();
            string vinho = gridVinho.CurrentRow.Cells[1].Value.ToString();

            int castasAdicionadas = AdicionarCasta(idVinho);

            MessageBox.Show("Foram Adicionadas Castas " + castasAdicionadas + " ao Vinho " + vinho + " com Sucesso!", "Atenção!");

            txPercentagem.Text = CastasVinhos_Metodos.VerPercentagemTotal(idVinho).ToString();
        }

        private void btAdicionarEnologo_Click(object sender, EventArgs e)
        {
            int idVinho = (int)gridVinho.CurrentRow.Cells[0].Value;
            DataRowView drv = (DataRowView)lbxEnologos.Items[0];
            string enologo = drv.Row["NomeEnologo"].ToString();
            string vinho = gridVinho.CurrentRow.Cells[1].Value.ToString();

            bool enologoaceite = AdicionarEnologo(idVinho);

            if (enologoaceite == true)
            {
                MessageBox.Show("O Enologo " + enologo + ", foi Adicionado ao Vinho " + vinho, "Atenção!");
            }
            else
            {
                MessageBox.Show("Ocorreu um Erro!", "Atenção!");
            }
        }

        private void btNovoVinho_Click(object sender, EventArgs e)
        {
            getVinhos();
            Inicio();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            getVinhosPorAprovar();
            Inicio();
        }

        private void btAprovarTudo_Click(object sender, EventArgs e)
        {
            DialogResult mensagem = MessageBox.Show("Tem a certeza que quer Aprovar todos os Vinhos?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (mensagem == DialogResult.Yes)
            {
                int numero = Vinho_Metodos.AprovarTudo();
                MessageBox.Show("Todos os Vinhos foram Aprovados!", "Alerta");

                getVinhos();
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }


    }
}