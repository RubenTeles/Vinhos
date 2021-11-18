using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL
{
    public static class Editar_Metodos
    {
        static SqlConnection vinhao_conexao = new SqlConnection(Properties.Settings.Default.vinhao);

        public static int NomeUpdate(Vinho V)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_EditarVinho_Nome_Update";

            comando.Parameters.AddWithValue("@vinhoID", V.VinhoID);
            comando.Parameters.AddWithValue("@nomeVinho", V.NomeVinho);

            vinhao_conexao.Open();
            int totaldelinhas = comando.ExecuteNonQuery();
            vinhao_conexao.Close();

            return totaldelinhas;
        }
        public static int DescricaoUpdate(Vinho V)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_EditarVinho_Descricao_Update";

            comando.Parameters.AddWithValue("@vinhoID", V.VinhoID);
            comando.Parameters.AddWithValue("@descricao", V.Descricao);

            vinhao_conexao.Open();
            int totaldelinhas = comando.ExecuteNonQuery();
            vinhao_conexao.Close();

            return totaldelinhas;
        }
        public static int FotoUpdate(Vinho V)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_EditarVinho_Foto_Update";

            comando.Parameters.AddWithValue("@vinhoID", V.VinhoID);
            comando.Parameters.AddWithValue("@foto", V.Foto);

            vinhao_conexao.Open();
            int totaldelinhas = comando.ExecuteNonQuery();
            vinhao_conexao.Close();

            return totaldelinhas;
        }
        public static int TipoUpdate(Vinho V)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_EditarVinho_Tipo_Update";

            comando.Parameters.AddWithValue("@vinhoID", V.VinhoID);
            comando.Parameters.AddWithValue("@tipo", V.TipoID);

            vinhao_conexao.Open();
            int totaldelinhas = comando.ExecuteNonQuery();
            vinhao_conexao.Close();

            return totaldelinhas;
        }
        public static int AnoUpdate(Vinho V)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_EditarVinho_Ano_Update";

            comando.Parameters.AddWithValue("@vinhoID", V.VinhoID);
            comando.Parameters.AddWithValue("@ano", V.Ano);

            vinhao_conexao.Open();
            int totaldelinhas = comando.ExecuteNonQuery();
            vinhao_conexao.Close();

            return totaldelinhas;
        }
        public static int RegiaoUpdate(Vinho V)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_EditarVinho_Regiao_Update";

            comando.Parameters.AddWithValue("@vinhoID", V.VinhoID);
            comando.Parameters.AddWithValue("@regiao", V.RegiaoID);

            vinhao_conexao.Open();
            int totaldelinhas = comando.ExecuteNonQuery();
            vinhao_conexao.Close();

            return totaldelinhas;

        }
        public static int ProdutorUpdate(Vinho V)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_EditarVinho_Produtor_Update";

            comando.Parameters.AddWithValue("@vinhoID", V.VinhoID);
            comando.Parameters.AddWithValue("@produtor", V.ProdutorID);

            vinhao_conexao.Open();
            int totaldelinhas = comando.ExecuteNonQuery();
            vinhao_conexao.Close();

            return totaldelinhas;

        }
        public static int TempuraUpdate(Vinho V)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_EditarVinho_Tempura_Update";

            comando.Parameters.AddWithValue("@vinhoID", V.VinhoID);
            comando.Parameters.AddWithValue("@tempura", V.Temperatura);

            vinhao_conexao.Open();
            int totaldelinhas = comando.ExecuteNonQuery();
            vinhao_conexao.Close();

            return totaldelinhas;

        }
        public static int TeorUpdate(Vinho V)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_EditarVinho_Teor_Update";

            comando.Parameters.AddWithValue("@vinhoID", V.VinhoID);
            comando.Parameters.AddWithValue("@teor", V.TeorAlcoolico);

            vinhao_conexao.Open();
            int totaldelinhas = comando.ExecuteNonQuery();
            vinhao_conexao.Close();

            return totaldelinhas;

        }
        public static int VolumeUpdate(Vinho V)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_EditarVinho_Volume_Update";

            comando.Parameters.AddWithValue("@vinhoID", V.VinhoID);
            comando.Parameters.AddWithValue("@volume", V.Volume);

            vinhao_conexao.Open();
            int totaldelinhas = comando.ExecuteNonQuery();
            vinhao_conexao.Close();

            return totaldelinhas;

        }
        public static int EnologoUpdate(int VinhoID)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_EditarVinho_Enologo_Update";

            comando.Parameters.AddWithValue("@vinhoID", VinhoID);

            vinhao_conexao.Open();
            int totaldelinhas = comando.ExecuteNonQuery();
            vinhao_conexao.Close();

            return totaldelinhas;

        }
        public static int CastaUpdate(int VinhoID)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_EditarVinho_Casta_Update";

            comando.Parameters.AddWithValue("@vinhoID", VinhoID);

            vinhao_conexao.Open();
            int totaldelinhas = comando.ExecuteNonQuery();
            vinhao_conexao.Close();

            return totaldelinhas;

        }
    }
}
