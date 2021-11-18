using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL
{
    public static class Produtor_Metodos
    {
        static SqlConnection vinhao_conexao = new SqlConnection(Properties.Settings.Default.vinhao);


        public static DataTable ProdutorSelect()
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_Produtor_Select";

            SqlDataReader reader;
            DataTable table = new DataTable();

            vinhao_conexao.Open();
            reader = comando.ExecuteReader();
            table.Load(reader);
            vinhao_conexao.Close();

            return table;
        }
        public static int ProdutorInsert(Produtor P)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_Produtor_Insert";

            comando.Parameters.AddWithValue("@nomeProdutor", P.NomeProdutor);
            comando.Parameters.AddWithValue("@URL", P.URL);

            vinhao_conexao.Open();
            int totaldelinhas = comando.ExecuteNonQuery();
            vinhao_conexao.Close();

            return totaldelinhas;
        }
        public static int ProdutorUpdate(Produtor P)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_Produtor_Update";

            comando.Parameters.AddWithValue("@produtorID", P.ProdutorID);
            comando.Parameters.AddWithValue("@nomeProdutor", P.NomeProdutor);
            comando.Parameters.AddWithValue("@URL", P.URL);

            vinhao_conexao.Open();
            int totaldelinhas = comando.ExecuteNonQuery();
            vinhao_conexao.Close();

            return totaldelinhas;
        }
        public static int ProdutorDelete(Produtor P)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_Produtor_Delete";

            comando.Parameters.AddWithValue("@produtorID", P.ProdutorID);

            vinhao_conexao.Open();
            int totaldelinhas = comando.ExecuteNonQuery();
            vinhao_conexao.Close();

            return totaldelinhas;
        }
    }
}
