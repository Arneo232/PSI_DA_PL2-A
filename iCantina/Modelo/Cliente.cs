using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Modelo
{
    internal class Cliente : Utilizador
    {
        public float Saldo { get; set; }   
        public List <Fatura> Faturas { get; set; }

        public Cliente()
        {
            Faturas = new List<Fatura>();
        }

        public Cliente(string name, int nif, float saldo) : base(name, nif)
        {
            Name = name;
            Nif = nif;
            Saldo = saldo;
            Faturas = new List<Fatura>();
        }
    }
}
