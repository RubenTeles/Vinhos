using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL
{
    public static class Vinho_Metodos
    {
        static SqlConnection vinhao_conexao = new SqlConnection(Properties.Settings.Default.vinhao);

        public static DataTable VinhoSelect()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = vinhao_conexao;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "usp_Vinho_Select";
            SqlDataReader reader;
            DataTable table = new DataTable();
            vinhao_conexao.Open();
            reader = command.ExecuteReader();
            table.Load(reader);
            vinhao_conexao.Close();
            return table;
        }
        public static DataTable VinhoSelect(int id_utilizador)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = vinhao_conexao;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "[usp_Vinho_SelectByUtilizador]";
            command.Parameters.AddWithValue("@id_utilizador", id_utilizador);
            SqlDataReader reader;
            DataTable table = new DataTable();
            vinhao_conexao.Open();
            reader = command.ExecuteReader();
            table.Load(reader);
            vinhao_conexao.Close();
            return table;
        }

        public static DataTable VinhoSelectByVinhoID(int vinhoID)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = vinhao_conexao;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "usp_Vinho_SelectByVinhoID";
            command.Parameters.AddWithValue("@vinhoID", vinhoID);
            SqlDataReader reader;
            DataTable table = new DataTable();
            vinhao_conexao.Open();
            reader = command.ExecuteReader();
            table.Load(reader);
            vinhao_conexao.Close();
            return table;
        }

        public static DataTable VinhoSelectByVinhoIDPorAprovar(int vinhoID)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = vinhao_conexao;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "usp_Vinho_SelectByVinhoIDPorAprovar";
            command.Parameters.AddWithValue("@vinhoID", vinhoID);
            SqlDataReader reader;
            DataTable table = new DataTable();
            vinhao_conexao.Open();
            reader = command.ExecuteReader();
            table.Load(reader);
            vinhao_conexao.Close();
            return table;
        }

        public static DataTable VinhoSelectInseridosRecentemente()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = vinhao_conexao;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "usp_Vinho_SelectInseridosRecentemente";
            SqlDataReader reader;
            DataTable table = new DataTable();
            vinhao_conexao.Open();
            reader = command.ExecuteReader();
            table.Load(reader);
            vinhao_conexao.Close();
            return table;
        }

        #region Procurar
        public static DataTable ProcurarNomeVinho(string procurar)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = vinhao_conexao;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "usp_Procurar_NomeVinho";
            command.Parameters.AddWithValue("@procurar", procurar);
            SqlDataReader reader;
            DataTable table = new DataTable();
            vinhao_conexao.Open();
            reader = command.ExecuteReader();
            table.Load(reader);
            vinhao_conexao.Close();
            return table;
        }
        public static DataTable ProcurarUtilizador(string procurar)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = vinhao_conexao;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "usp_Procurar_Utilizador";
            command.Parameters.AddWithValue("@procurar", procurar);
            SqlDataReader reader;
            DataTable table = new DataTable();
            vinhao_conexao.Open();
            reader = command.ExecuteReader();
            table.Load(reader);
            vinhao_conexao.Close();
            return table;
        }
        public static DataTable ProcurarRegiao(string procurar)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = vinhao_conexao;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "usp_Procurar_Regiao";
            command.Parameters.AddWithValue("@procurar", procurar);
            SqlDataReader reader;
            DataTable table = new DataTable();
            vinhao_conexao.Open();
            reader = command.ExecuteReader();
            table.Load(reader);
            vinhao_conexao.Close();
            return table;
        }
        public static DataTable ProcurarCasta(string procurar)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = vinhao_conexao;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "usp_Procurar_Casta";
            command.Parameters.AddWithValue("@procurar", procurar);
            SqlDataReader reader;
            DataTable table = new DataTable();
            vinhao_conexao.Open();
            reader = command.ExecuteReader();
            table.Load(reader);
            vinhao_conexao.Close();
            return table;
        }
        public static DataTable ProcurarEnologo(string procurar)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = vinhao_conexao;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "usp_Procurar_Enologo";
            command.Parameters.AddWithValue("@procurar", procurar);
            SqlDataReader reader;
            DataTable table = new DataTable();
            vinhao_conexao.Open();
            reader = command.ExecuteReader();
            table.Load(reader);
            vinhao_conexao.Close();
            return table;
        }
        public static DataTable ProcurarProdutor(string procurar)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = vinhao_conexao;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "usp_Procurar_Produtor";
            command.Parameters.AddWithValue("@procurar", procurar);
            SqlDataReader reader;
            DataTable table = new DataTable();
            vinhao_conexao.Open();
            reader = command.ExecuteReader();
            table.Load(reader);
            vinhao_conexao.Close();
            return table;
        }
        public static DataTable ProcurarTipo(string procurar)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = vinhao_conexao;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "usp_Procurar_Tipo";
            command.Parameters.AddWithValue("@procurar", procurar);
            SqlDataReader reader;
            DataTable table = new DataTable();
            vinhao_conexao.Open();
            reader = command.ExecuteReader();
            table.Load(reader);
            vinhao_conexao.Close();
            return table;
        }
        #endregion
        public static string VinhoInsertCastasEnologos(Vinho V)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_Vinho_Inserir";
            comando.Parameters.AddWithValue("@nome", V.NomeVinho);
            comando.Parameters.AddWithValue("@descricao", V.Descricao);
            comando.Parameters.AddWithValue("@userID", V.UtilizadorID);
            comando.Parameters.AddWithValue("@tipoID", V.TipoID);
            comando.Parameters.AddWithValue("@regiaoID", V.RegiaoID);
            comando.Parameters.AddWithValue("@produtorID", V.ProdutorID);
            comando.Parameters.AddWithValue("@foto", V.Foto);
            comando.Parameters.AddWithValue("@volume", V.Volume);
            comando.Parameters.AddWithValue("@teor", V.TeorAlcoolico);
            comando.Parameters.AddWithValue("@ano", V.Ano);
            comando.Parameters.AddWithValue("@temperatura", V.Temperatura);

            SqlCommand command_castas = new SqlCommand();
            command_castas.Connection = vinhao_conexao;
            command_castas.CommandType = CommandType.StoredProcedure;
            command_castas.CommandText = "usp_CastaVinhos_InsertCastas";
            //criar string com as castas a associar ao vinho (parâmetro da SP AssociarCastas)
            string castas = "";
            foreach (var item in V.Castas)
            {
                castas += item + ",";
            }
            castas = castas.Remove(castas.Length - 1);
            command_castas.Parameters.AddWithValue("@castas", castas);

            SqlCommand comando_enologos = new SqlCommand();
            comando_enologos.Connection = vinhao_conexao;
            comando_enologos.CommandType = CommandType.StoredProcedure;
            comando_enologos.CommandText = "usp_CastaVinhos_InsertCastas";
            //criar string com as castas a associar ao vinho (parâmetro da SP AssociarCastas)
            string enolgos = "";
            foreach (var item in V.Enologos)
            {
                enolgos += item + ",";
            }
            enolgos = enolgos.Remove(enolgos.Length - 1);
            comando_enologos.Parameters.AddWithValue("@enologos", enolgos);



            vinhao_conexao.Open();
            string id_vinho = comando.ExecuteScalar().ToString();
            command_castas.Parameters.AddWithValue("@vinho", id_vinho);
            command_castas.ExecuteNonQuery();
            comando_enologos.ExecuteNonQuery();
            vinhao_conexao.Close();

            return id_vinho;
        }
        public static string VinhoInsert(Vinho V)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_Vinho_Inserir";
            comando.Parameters.AddWithValue("@nome", V.NomeVinho);
            comando.Parameters.AddWithValue("@descricao", V.Descricao);
            comando.Parameters.AddWithValue("@userID", V.UtilizadorID);
            comando.Parameters.AddWithValue("@tipoID", V.TipoID);
            comando.Parameters.AddWithValue("@regiaoID", V.RegiaoID);
            comando.Parameters.AddWithValue("@produtorID", V.ProdutorID);
            comando.Parameters.AddWithValue("@foto", V.Foto);
            comando.Parameters.AddWithValue("@volume", V.Volume);
            comando.Parameters.AddWithValue("@teor", V.TeorAlcoolico);
            comando.Parameters.AddWithValue("@ano", V.Ano);
            comando.Parameters.AddWithValue("@temperatura", V.Temperatura);



            vinhao_conexao.Open();
            string id_vinho = comando.ExecuteScalar().ToString();
            vinhao_conexao.Close();

            return id_vinho;
        }
        public static int VinhoUpdate(Vinho V)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_Vinho_Update";
            comando.Parameters.AddWithValue("@vinhoID", V.VinhoID);
            comando.Parameters.AddWithValue("@nome", V.NomeVinho);
            comando.Parameters.AddWithValue("@descricao", V.Descricao);
            comando.Parameters.AddWithValue("@utilizadorID", V.UtilizadorID);
            comando.Parameters.AddWithValue("@tipoID", V.TipoID);
            comando.Parameters.AddWithValue("@regiaoID", V.RegiaoID);
            comando.Parameters.AddWithValue("@produtorID", V.ProdutorID);
            comando.Parameters.AddWithValue("@foto", V.Foto);
            comando.Parameters.AddWithValue("@volume", V.Volume);
            comando.Parameters.AddWithValue("@teor", V.TeorAlcoolico);
            comando.Parameters.AddWithValue("@ano", V.Ano);
            comando.Parameters.AddWithValue("@temperatura", V.Temperatura);

            vinhao_conexao.Open();
            int total_linhas = comando.ExecuteNonQuery();
            vinhao_conexao.Close();
            return total_linhas;

        }

        public static int VinhoAprovar(Vinho V)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_Vinho_Aprovar";
            comando.Parameters.AddWithValue("@vinhoID", V.VinhoID);

            vinhao_conexao.Open();
            int total_linhas = comando.ExecuteNonQuery();
            vinhao_conexao.Close();
            return total_linhas;
        }

        public static int UpdateFoto(int vinhoID, string foto)
        {

            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_Vinho_UpdateFoto";
            comando.Parameters.AddWithValue("@foto", foto);
            comando.Parameters.AddWithValue("@vinhosID", vinhoID);

            vinhao_conexao.Open();
            int total_linhas = comando.ExecuteNonQuery();
            vinhao_conexao.Close();
            return total_linhas;

        }

        public static int VinhoDelete(int vinhoID)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_Vinho_Delete";
            comando.Parameters.AddWithValue("@vinhoID", vinhoID);

            vinhao_conexao.Open();
            int total_linhas = comando.ExecuteNonQuery();
            vinhao_conexao.Close();
            return total_linhas;
        }

        public static DataTable SelectVinhosPorAprovar()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = vinhao_conexao;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "usp_Vinho_SelectPorAprovar";
            SqlDataReader reader;
            DataTable table = new DataTable();
            vinhao_conexao.Open();
            reader = command.ExecuteReader();
            table.Load(reader);
            vinhao_conexao.Close();
            return table;
        }


        public static int MostrarVinhosPorAprovar()
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_Vinho_NumeroPorAprovar";

            vinhao_conexao.Open();
            int vinhosPorAprovar = (int)comando.ExecuteScalar();

            vinhao_conexao.Close();
            return vinhosPorAprovar;
        }

        public static int NumeroDeVinhos()
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_Vinho_NumeroDeVinhos";

            vinhao_conexao.Open();
            int numeroDeVinhos = (int)comando.ExecuteScalar();
            vinhao_conexao.Close();

            return numeroDeVinhos;

        }

        public static void RegistarComentarioClassificacao(int idVinho, int idUtilizador, string comentario)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = vinhao_conexao;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "VinhoRegistarComentario";
            command.Parameters.AddWithValue("@idVinho", idVinho);
            command.Parameters.AddWithValue("@comentario", comentario);
            command.Parameters.AddWithValue("@idUtilizador", idUtilizador);
            vinhao_conexao.Open();
            command.ExecuteNonQuery();
            vinhao_conexao.Close();
        }


        public static int AprovarTudo()
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_Vinho_AprovarTudo";

            vinhao_conexao.Open();
            int vinhos = comando.ExecuteNonQuery();
            vinhao_conexao.Close();
            return vinhos;
        }

        public static void AdicionarFavorito(int idVinho, int idUtilizador)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = vinhao_conexao;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "usp_Vinho_Favorito_Insert";
            command.Parameters.AddWithValue("@idVinho", idVinho);
            command.Parameters.AddWithValue("@idUtilizador", idUtilizador);
            vinhao_conexao.Open();
            command.ExecuteNonQuery();
            vinhao_conexao.Close();
        }
        public static void RemoverFavorito(int idVinho, int idUtilizador)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = vinhao_conexao;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "usp_Vinho_Favorito_Delete";
            command.Parameters.AddWithValue("@idVinho", idVinho);
            command.Parameters.AddWithValue("@idUtilizador", idUtilizador);
            vinhao_conexao.Open();
            command.ExecuteNonQuery();
            vinhao_conexao.Close();
        }
        public static int MostrarSeEFavorito(int idVinho, int idUtilizador)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = vinhao_conexao;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "usp_Vinho_Favorito_Select";
            comando.Parameters.AddWithValue("@idVinho", idVinho);
            comando.Parameters.AddWithValue("@idUtilizador", idUtilizador);

            vinhao_conexao.Open();
            int favorito = 0;
            try
            {
                favorito = (int)comando.ExecuteScalar();
            }
            catch (Exception)
            {
                favorito = 0;
            }


            vinhao_conexao.Close();
            return favorito;
        }

    }
}
