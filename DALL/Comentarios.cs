using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL
{
    public class Comentarios
    {
        public int? IdComentario { get; set; }

        public string Comentario { get; set; }


        public int? UtilizadorID { get; set; }

        public int? VinhoID { get; set; }
    }
    public class Classificacao
    {
        public int? IdComentario { get; set; }

        public double Pontuacao { get; set; }

        public int? UtilizadorID { get; set; }

        public int? VinhoID { get; set; }
    }
}
