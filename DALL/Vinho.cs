using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DALL
{

    public class Vinho
    {
        static SqlConnection vinhao_conexao = new SqlConnection(Properties.Settings.Default.vinhao);


        public int VinhoID { get; set; }
        public string NomeVinho { get; set; }
        public string Descricao { get; set; }
        public string Foto { get; set; }
        public int? Ano { get; set; }
        public decimal? Volume { get; set; }
        public decimal? TeorAlcoolico { get; set; }
        public string Temperatura { get; set; }
        public int? RegiaoID { get; set; }
        public int? ProdutorID { get; set; }
        public int? UtilizadorID { get; set; }
        public int? TipoID { get; set; }
        public List<string> Castas { get; set; }
        public List<string> Enologos { get; set; }

    }
}
