using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA.Modelo
{
    internal class Prato
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public bool Tipo { get; set; }
        public bool Ativo { get; set; }
    }
}
