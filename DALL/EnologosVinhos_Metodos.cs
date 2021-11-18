using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL
{
    public static class EnologosVinhos_Metodos
    {

        static SqlConnection vinhao_conexao = new SqlConnection(Properties.Settings.Default.vinhao);

        public static DataTable VerEnologosdoVinhos(int idVinho)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_VerEnologosDoVinho";
            comando.Parameters.AddWithValue("@idVinho", idVinho);
            SqlDataReader reader;
            DataTable table = new DataTable();
            vinhao_conexao.Open();
            reader = comando.ExecuteReader();
            table.Load(reader);
            vinhao_conexao.Close();

            return table;
        }

        public static DataTable RestantesEnologosdoVinhos(int idVinho)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_VerRestantesEnologos";
            comando.Parameters.AddWithValue("@idVinho", idVinho);
            SqlDataReader reader;
            DataTable table = new DataTable();
            vinhao_conexao.Open();
            reader = comando.ExecuteReader();
            table.Load(reader);
            vinhao_conexao.Close();

            return table;
        }

        public static int EnologosInsert(int Enologo, int Vinho)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_EnologosVinhos_Insert";

            comando.Parameters.AddWithValue("@idVinho", Vinho);
            comando.Parameters.AddWithValue("@idEnologo", Enologo);


            vinhao_conexao.Open();
            int totaldelinhas = comando.ExecuteNonQuery();
            vinhao_conexao.Close();
            return totaldelinhas;
        }

        public static int EnologosInsert(EnologosVinhos EV)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_EnologosVinhos_Insert";

            comando.Parameters.AddWithValue("@idVinho", EV.VinhoID);
            comando.Parameters.AddWithValue("@idEnologo", EV.EnologoID);


            vinhao_conexao.Open();
            int totaldelinhas = comando.ExecuteNonQuery();
            vinhao_conexao.Close();
            return totaldelinhas;
        }

        public static void RemoverEnologo(int enologovinhosID)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "[usp_EnologosVinhos_Delete]";

            comando.Parameters.AddWithValue("@idVinhoEnologo", enologovinhosID);


            vinhao_conexao.Open();
            int totaldelinhas = comando.ExecuteNonQuery();
            vinhao_conexao.Close();

        }
    }
}
