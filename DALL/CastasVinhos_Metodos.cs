using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL
{
    public static class CastasVinhos_Metodos
    {

        static SqlConnection vinhao_conexao = new SqlConnection(Properties.Settings.Default.vinhao);

        public static void InserirCastasVinhos(int idVinho, int idCasta, decimal percentagem)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_CastaVinhos_Insert";

            comando.Parameters.AddWithValue("@idVinho", idVinho);
            comando.Parameters.AddWithValue("@idCasta", idCasta);
            comando.Parameters.AddWithValue("@percentagem", percentagem);
            vinhao_conexao.Open();
            int totaldelinhas = comando.ExecuteNonQuery();
            vinhao_conexao.Close();

        }

        public static decimal InserirCastasVinhos(CastasVinhos CV)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_CastaVinhos_InsertCasta";

            comando.Parameters.AddWithValue("@idVinho", CV.VinhoID);
            comando.Parameters.AddWithValue("@idCasta", CV.CastaID);
            comando.Parameters.AddWithValue("@percentagem", CV.Percentagem);

            SqlCommand comandoVerPercentagem = new SqlCommand();
            comandoVerPercentagem.Connection = vinhao_conexao;
            comandoVerPercentagem.CommandType = CommandType.StoredProcedure;
            comandoVerPercentagem.CommandText = "usp_CastasVinhos_MostrarPercentagemTotal";

            comandoVerPercentagem.Parameters.AddWithValue("@idVinho", CV.VinhoID);

            vinhao_conexao.Open();
            int totaldelinhas = comando.ExecuteNonQuery();
            decimal percentagemTotal = decimal.Parse(comandoVerPercentagem.ExecuteScalar().ToString());
            vinhao_conexao.Close();
            return percentagemTotal;

        }

        public static void AssociarCasta(int idVinho, int idCasta, decimal percentagem)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_CastaVinhos_Insert";

            comando.Parameters.AddWithValue("@idVinho", idVinho);
            comando.Parameters.AddWithValue("@idCasta", idCasta);
            comando.Parameters.AddWithValue("@percentagem", percentagem);
            vinhao_conexao.Open();
            int totaldelinhas = comando.ExecuteNonQuery();
            vinhao_conexao.Close();

        }

        public static void RemoverCasta(int castasvinhosID)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_CastasVinhos_Delete";

            comando.Parameters.AddWithValue("@idVinhoCasta", castasvinhosID);


            vinhao_conexao.Open();
            int totaldelinhas = comando.ExecuteNonQuery();
            vinhao_conexao.Close();

        }

        public static DataTable VerCastasdoVinhos(int idVinho)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_VerCastasDoVinho";
            comando.Parameters.AddWithValue("@idVinho", idVinho);
            SqlDataReader reader;
            DataTable table = new DataTable();
            vinhao_conexao.Open();
            reader = comando.ExecuteReader();
            table.Load(reader);
            vinhao_conexao.Close();

            return table;
        }

        public static DataTable RestantesCastasdoVinhos(int idVinho)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_VerRestantesCastas";
            comando.Parameters.AddWithValue("@idVinho", idVinho);
            SqlDataReader reader;
            DataTable table = new DataTable();
            vinhao_conexao.Open();
            reader = comando.ExecuteReader();
            table.Load(reader);
            vinhao_conexao.Close();

            return table;
        }

        public static int CastaVinhosUpdate(int castasvinhosID, int idVinho, int idCasta, decimal percentagem)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_AssociarCasta";


            comando.Parameters.AddWithValue("@castasvinhosID", castasvinhosID);
            comando.Parameters.AddWithValue("@idVinho", idVinho);
            comando.Parameters.AddWithValue("@idCasta", idCasta);
            comando.Parameters.AddWithValue("@percentagem", percentagem);

            vinhao_conexao.Open();
            int totaldelinhas = comando.ExecuteNonQuery();
            vinhao_conexao.Close();

            return totaldelinhas;
        }

        public static decimal VerPercentagemTotal(int idVinho)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_CastasVinhos_MostrarPercentagemTotal";
            comando.Parameters.AddWithValue("@idVinho", idVinho);

            vinhao_conexao.Open();
            decimal percentagemTotal = 0;
            try
            {
               percentagemTotal = decimal.Parse(comando.ExecuteScalar().ToString());
            }
            catch (Exception)
            {
                comando.ExecuteScalar();
                percentagemTotal = 0;
            }
               
           
            vinhao_conexao.Close();
            return percentagemTotal;

        }

    }
}
