using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA.Modelo
{
    internal class Fatura
    {
        public int Id { get; set; }
        public float Total { get; set; }
        public DateTime DataHora { get; set; }
        public Cliente Cliente { get; set; }
        public Menu Menu { get; set; }
        public List <Item_fatura> ItemsFatura { get; set; }
    }
}
