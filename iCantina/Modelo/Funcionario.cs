using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Modelo
{
    internal class Funcionario : Utilizador
    {
        public int Id { get; set; }
        public string Username { get; set; }

        public Funcionario()
        {
        }

        public Funcionario(string name, int nif, string username) : base(name, nif)
        {
            Name = name;
            Nif = nif;
            Username = username;
        }
    }
    
}
