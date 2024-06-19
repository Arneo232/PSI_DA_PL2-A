using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Modelo
{
    internal class Professor : Cliente
    {
        public string Email { get; set; }

        public Professor()
        {
        }

        public Professor(string name, int nif, float saldo, string email) : base(name, nif, saldo)
        {
            Name = name;
            Nif = nif;
            Saldo = saldo;
            Email = email;
        }
    }
}
