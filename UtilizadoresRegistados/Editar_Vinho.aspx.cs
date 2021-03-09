using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DALL;

namespace Site_Vinhao.UtilizadoresRegistados
{
    public partial class Editar_Vinho : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack == false)
            {
                PreencherList();
                int vinho = 0;
                //preencher castas
                if (Request.QueryString["vinho"] != null)
                    vinho = int.Parse(Request.QueryString["vinho"].ToString());
                // obter dados e preencher controlos
                //DUVIDA
                //Vinho v = Vinho_Metodos.VinhoSelectByVinhoID(vinho);
                //DUVIDA
                //txNome.Text = v.NomeVinho;
                //txDescricao.Text = v.Descricao;
                //cbProdutor.SelectedValue = v.ProdutorID.ToString();
                //cbRegiao.SelectedValue = v.RegiaoID.ToString();
                //cbTipo.SelectedValue = v.TipoID.ToString();
                //txAno.Text = v.Ano.ToString();
                //txTemperatura.Text = v.Temperatura;
                //txTemperatura.Text = v.TeorAlcoolico.ToString();
                //txVolume.Text = v.Volume.ToString();
                //foto
                //foto.ImageUrl = v.Foto;
                //ViewState["foto"] = foto.ImageUrl;
                //PreencherCastas(vinho);
            }
        }

        void PreencherList()
        {
            //--Produtor--
            cbProdutor.DataSource = Produtor_Metodos.ProdutorSelect();
            cbProdutor.DataTextField = "NomeProdutor";
            cbProdutor.DataValueField = "ProdutorID";
            cbProdutor.DataBind();

            //--Região--
            cbRegiao.DataSource = Regiao_Metodos.RegiaoSelect();
            cbRegiao.DataTextField = "NomeRegiao";
            cbRegiao.DataValueField = "IDRegiao";
            cbRegiao.DataBind();

            //--Tipo de Vinho--
            cbTipo.DataSource = Tipo_Metodos.TipoSelect();
            cbTipo.DataTextField = "NomeTipo";
            cbTipo.DataValueField = "TipoID";
            cbTipo.DataBind();
        }

        void PreencherCastas(int vinho)
        {
            gridCastasVinho.DataSource = CastasVinhos_Metodos.VerCastasdoVinhos(vinho);
            gridCastasVinho.DataBind();
            gridCastas.DataSource = CastasVinhos_Metodos.RestantesCastasdoVinhos(vinho);
            gridCastas.DataBind();
        }

        protected void btAssociarCasta_Click(object sender, EventArgs e)
        {
            //obter dados referentes ao vinho e à casta seleccionada
            int vinho = int.Parse(Request.QueryString["vinho"].ToString());
            int casta = int.Parse(gridCastas.SelectedRow.Cells[0].Text);
            decimal percentagem = decimal.Parse(txPercentagem.Text);
            //inserir registo
            CastasVinhos_Metodos.AssociarCasta(vinho, casta, percentagem);
            //actualizar controlos
            PreencherCastas(vinho);
        }

        protected void btRemoverCasta_Click(object sender, EventArgs e)
        {
            //obter ID do registo VinhoCasta a remover
            int vinho_casta = int.Parse(gridCastasVinho.SelectedRow.Cells[1].Text);
            //remover registo
            CastasVinhos_Metodos.RemoverCasta(vinho_casta);
            //actualizar controlos
            int vinho = int.Parse(Request.QueryString["vinho"].ToString());
            PreencherCastas(vinho);
        }

        protected void btInserir_Click(object sender, EventArgs e)
        {
            Vinho vinho = new Vinho();
            //obter ID do vinho a actualizar



            vinho.VinhoID = int.Parse(Request.QueryString["vinho"].ToString());
            vinho.NomeVinho = txNome.Text;
            vinho.Descricao = txDescricao.Text;
            vinho.ProdutorID = int.Parse(cbProdutor.SelectedValue);
            vinho.RegiaoID = int.Parse(cbRegiao.SelectedValue);
            vinho.TipoID = int.Parse(cbTipo.SelectedValue);
            vinho.Ano = int.Parse(txAno.Text.Trim());
            vinho.Temperatura = txTemperatura.Text;
            vinho.TeorAlcoolico = decimal.Parse(txTeorAlcoolico.Text.Trim());
            vinho.Volume = decimal.Parse(txVolume.Text.Trim());
            //foto – verificar a existência de ficheiro e o tipo
            if (uploadFoto.HasFile)
            {
                bool ok = false;
                string[] ext = { ".jpg", ".jpeg", ".png", ".gif", ".tiff" };
                string extensao = System.IO.Path.GetExtension(uploadFoto.FileName).ToString();
                foreach (var item in ext)
                {
                    if (extensao == item) ok = true;
                }
                if (ok)
                {
                    uploadFoto.SaveAs(Server.MapPath("~/imagens/") + uploadFoto.FileName);
                    vinho.Foto = "~/imagens/" + uploadFoto.FileName;
                }
                else
                    //ficheiro inválido - mantém informação que já se encontra na tabela
                    vinho.Foto = ViewState["foto"].ToString();
            }
            else
                //não foi seleccionado ficheiro - mantém informação que já se encontra na tabela
                vinho.Foto = ViewState["foto"].ToString();
            Vinho_Metodos.VinhoUpdate(vinho);
            Response.Redirect("Area_Pessoal.aspx");
        }
    }
}