using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL
{
    public static class Utilizador_Metodos
    {
        static SqlConnection vinhao_conexao = new SqlConnection(Properties.Settings.Default.vinhao);

        public static DataTable UtilizadorSelect()
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_Utilizadores_Select";

            SqlDataReader reader;
            DataTable table = new DataTable();

            vinhao_conexao.Open();
            reader = comando.ExecuteReader();
            table.Load(reader);
            vinhao_conexao.Close();

            return table;
        }

        public static void UtilizadorInsert(Utilizador U)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandText = "usp_Utilizador_Insert";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nome", U.Nome);
            comando.Parameters.AddWithValue("@email", U.Email);
            comando.Parameters.AddWithValue("@data", U.DataNascimento);
            comando.Parameters.AddWithValue("@user_id", U.UserID);
            vinhao_conexao.Open();
            comando.ExecuteNonQuery();
            vinhao_conexao.Close();
        }
        public static int UtilizadorUpdate(Utilizador U)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_Utilizador_Update";

            comando.Parameters.AddWithValue("@utilizadorID", U.UtilizadorID);
            comando.Parameters.AddWithValue("@nomeUtilizador", U.Nome);
            comando.Parameters.AddWithValue("@descricao", U.Descricao);
            comando.Parameters.AddWithValue("@email", U.Email);
            comando.Parameters.AddWithValue("@datanascimento", U.DataNascimento);

            vinhao_conexao.Open();
            int totaldelinhas = comando.ExecuteNonQuery();
            vinhao_conexao.Close();

            return totaldelinhas;
        }


        public static string UtilizadorObterID(string UserID)
        {
            string id = "";
            SqlCommand command = new SqlCommand();
            command.Connection = vinhao_conexao;
            command.CommandText = "usp_Utilizador_ObterID";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@user_id", UserID);
            vinhao_conexao.Open();
            SqlDataReader reader;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                id = reader[0].ToString();
            }
            vinhao_conexao.Close();
            return id;
        }

        public static string UtilizadorObterNome(int UtilizadorID)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandText = "usp_Utilizador_ObterNome";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@utilizadorID", UtilizadorID);

            vinhao_conexao.Open();
            string nomeUtilizador = comando.ExecuteScalar().ToString();

            vinhao_conexao.Close();
            return nomeUtilizador;
        }

        public static int UtilizadorDelete(Utilizador u)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_Utilizador_Delete";

            comando.Parameters.AddWithValue("@utilizadorID", u.UtilizadorID);

            vinhao_conexao.Open();
            int totaldelinhas = comando.ExecuteNonQuery();
            vinhao_conexao.Close();

            return totaldelinhas;
        }

        public static int ValidarNome(string UserName)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandText = "usp_Utilizador_ValidarNome";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@userName", UserName);
            vinhao_conexao.Open();
            int valido = (int)comando.ExecuteScalar();
            vinhao_conexao.Close();
            return valido;
        }

        public static DataTable UtilizadorSelectBloqueados()
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_Utilizadores_SelectBloqueados";


            SqlDataReader reader;
            DataTable table = new DataTable();

            vinhao_conexao.Open();
            reader = comando.ExecuteReader();
            table.Load(reader);
            vinhao_conexao.Close();

            return table;
        }

        public static int UtilizadorDesbloquear(Utilizador u)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_Utilizador_Desbloquear";

            comando.Parameters.AddWithValue("@utilizadorID", u.UtilizadorID);

            vinhao_conexao.Open();
            int totaldelinhas = comando.ExecuteNonQuery();
            vinhao_conexao.Close();

            return totaldelinhas;
        }
        public static DataTable VinhoSelectByUtilizadorID(int UtilizadorID)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_Vinho_SelectByUtilizador";
            comando.Parameters.AddWithValue("@id_utilizador", UtilizadorID);
            SqlDataReader reader;
            DataTable table = new DataTable();
            vinhao_conexao.Open();
            reader = comando.ExecuteReader();
            table.Load(reader);
            vinhao_conexao.Close();
            return table;
        }

        public static DataTable VinhoSelectByFavorito(int UtilizadorID)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_Vinho_SelectByUtilizadorFavorito";
            comando.Parameters.AddWithValue("@id_utilizador", UtilizadorID);
            SqlDataReader reader;
            DataTable table = new DataTable();
            vinhao_conexao.Open();
            reader = comando.ExecuteReader();
            table.Load(reader);
            vinhao_conexao.Close();
            return table;
        }
        public static DataTable VinhoSelectByUtilizadorIDPorAprovar(int UtilizadorID)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_Vinho_SelectByUtilizadorNaoAprovado";
            comando.Parameters.AddWithValue("@id_utilizador", UtilizadorID);
            SqlDataReader reader;
            DataTable table = new DataTable();
            vinhao_conexao.Open();
            reader = comando.ExecuteReader();
            table.Load(reader);
            vinhao_conexao.Close();
            return table;
        }

        public static DataTable Select_Perfil(int UtilizadorID)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_Utilizadores_SelectPerfil";
            comando.Parameters.AddWithValue("@utilizadorID", UtilizadorID);
            SqlDataReader reader;
            DataTable table = new DataTable();
            vinhao_conexao.Open();
            reader = comando.ExecuteReader();
            table.Load(reader);
            vinhao_conexao.Close();
            return table;
        }
        public static int UtilizadorUpdateEmail(Utilizador U)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_Utilizador_Update_Foto";

            comando.Parameters.AddWithValue("@utilizadorID", U.UtilizadorID);
            comando.Parameters.AddWithValue("@email", U.Email);

            vinhao_conexao.Open();
            int totaldelinhas = comando.ExecuteNonQuery();
            vinhao_conexao.Close();

            return totaldelinhas;
        }
        public static int UtilizadorUpdateDataNascimento(Utilizador U)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_Utilizador_Update_DataNascimento";

            comando.Parameters.AddWithValue("@utilizadorID", U.UtilizadorID);
            comando.Parameters.AddWithValue("@datanascimento", U.DataNascimento);

            vinhao_conexao.Open();
            int totaldelinhas = comando.ExecuteNonQuery();
            vinhao_conexao.Close();

            return totaldelinhas;
        }
        public static int UtilizadorUpdateDescricao(Utilizador U)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_Utilizador_Update_Descricao";

            comando.Parameters.AddWithValue("@utilizadorID", U.UtilizadorID);
            comando.Parameters.AddWithValue("@descricao", U.Descricao);

            vinhao_conexao.Open();
            int totaldelinhas = comando.ExecuteNonQuery();
            vinhao_conexao.Close();

            return totaldelinhas;
        }
        public static int UtilizadorUpdateNome(Utilizador U)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_Utilizador_Update_Nome";

            comando.Parameters.AddWithValue("@utilizadorID", U.UtilizadorID);
            comando.Parameters.AddWithValue("@nomeUtilizador", U.Nome);

            vinhao_conexao.Open();
            int totaldelinhas = comando.ExecuteNonQuery();
            vinhao_conexao.Close();

            return totaldelinhas;
        }
        public static int UtilizadorUpdateFoto(Utilizador U)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_Utilizador_Update_Foto";

            comando.Parameters.AddWithValue("@utilizadorID", U.UtilizadorID);
            comando.Parameters.AddWithValue("@foto", U.Foto);

            vinhao_conexao.Open();
            int totaldelinhas = comando.ExecuteNonQuery();
            vinhao_conexao.Close();

            return totaldelinhas;
        }
        public static int MostrarNumeroUtilizadores()
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_Utilizador_NumeroDeUtilizadores";

            vinhao_conexao.Open();
            int numeroDeUtilizadores = (int)comando.ExecuteScalar();

            vinhao_conexao.Close();
            return numeroDeUtilizadores;
        }

    }
}
