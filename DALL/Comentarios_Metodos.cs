using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL
{
    public static class Comentarios_Metodos
    {
        static SqlConnection vinhao_conexao = new SqlConnection(Properties.Settings.Default.vinhao);

        public static DataTable ComentarioSelect(int idVinho)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_Comentario_Select";
            comando.Parameters.AddWithValue("@idVinho", idVinho);

            SqlDataReader reader;
            DataTable table = new DataTable();


            vinhao_conexao.Open();
            reader = comando.ExecuteReader();
            table.Load(reader);
            vinhao_conexao.Close();

            return table;
        }
        public static int Comentario_Insert(Comentarios C)
        {

            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_Comentario_Insert";

            comando.Parameters.AddWithValue("@idVinho", C.VinhoID);
            comando.Parameters.AddWithValue("@idUtilizador", C.UtilizadorID);
            comando.Parameters.AddWithValue("@comentario", C.Comentario);
            comando.Parameters.AddWithValue("@classificacao", C.Classificacao);


            vinhao_conexao.Open();
            int totaldelinhas = comando.ExecuteNonQuery();
            vinhao_conexao.Close();

            return totaldelinhas;
        }

        public static double ClassificaçãoMedia(int vinhoid)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = vinhao_conexao;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "usp_Comentario_ClassificacaoMedia";
            command.Parameters.AddWithValue("@idVinho", vinhoid);
            vinhao_conexao.Open();

            double media = double.Parse(command.ExecuteScalar().ToString());

            vinhao_conexao.Close();
            return media;
        }
    }
}
