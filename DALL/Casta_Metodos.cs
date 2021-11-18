using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL
{
    public static class Casta_Metodos
    {
        static SqlConnection vinhao_conexao = new SqlConnection(Properties.Settings.Default.vinhao);


        public static DataTable CastaSelect ()
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_Casta_Select";
            
            SqlDataReader reader;
            DataTable table = new DataTable();

            vinhao_conexao.Open();
            reader = comando.ExecuteReader();
            table.Load(reader);
            vinhao_conexao.Close();

            return table;
        }
        public static int CastaInsert(Casta C)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_Casta_Inserir";

            comando.Parameters.AddWithValue("@nome", C.NomeCasta);
            comando.Parameters.AddWithValue("@descricao", C.DescricaoCasta);

            vinhao_conexao.Open();
            int totaldelinhas = comando.ExecuteNonQuery();
            vinhao_conexao.Close();

            return totaldelinhas;
        }
        public static int CastaUpdate(Casta C)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_Casta_Update";

            comando.Parameters.AddWithValue("@castaID", C.CastaID);
            comando.Parameters.AddWithValue("@nome", C.NomeCasta);
            comando.Parameters.AddWithValue("@descricao", C.DescricaoCasta);

            vinhao_conexao.Open();
            int totaldelinhas = comando.ExecuteNonQuery();
            vinhao_conexao.Close();

            return totaldelinhas;
        }
        public static int CastaDelete(Casta C)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_Casta_Delete";

            comando.Parameters.AddWithValue("@castaID", C.CastaID);

            vinhao_conexao.Open();
            int totaldelinhas = comando.ExecuteNonQuery();
            vinhao_conexao.Close();

            return totaldelinhas;
        }



    }
}
