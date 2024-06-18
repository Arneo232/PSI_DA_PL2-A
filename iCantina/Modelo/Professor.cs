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

        public Professor(string email, string name, int nif, float saldo) : base(name, nif, saldo)
        {
            Email = email;
            Name = name;
            Nif = nif;
            Saldo = saldo;
        }
    }
}
