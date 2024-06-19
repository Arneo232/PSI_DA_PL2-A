using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace iCantina.Modelo
{
    internal class Estudante : Cliente
    {
        public int NumEstudante { get; set; }

        public Estudante()
        {
        }

        public Estudante(string name, int nif, float saldo, int numEstudante) : base(name, nif, saldo)
        {
            Name = name;
            Nif = nif;
            Saldo = saldo;
            NumEstudante = numEstudante;
        }
    }
}
