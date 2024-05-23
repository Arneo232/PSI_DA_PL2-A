using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA.Modelo
{
    internal class Cliente : Utilizador
    {
        public int Id { get; set; }
        public float Saldo { get; set; }
        public List <Fatura> Faturas { get; set; }
    }
}
