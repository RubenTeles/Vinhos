using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL
{
    public class Utilizador
    {
        public int UtilizadorID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public string UserID { get; set; }
    }
}
