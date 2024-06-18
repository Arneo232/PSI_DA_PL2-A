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

        public Estudante(int numEstudante, string name, int nif, float saldo) : base(name, nif, saldo)
        {
            NumEstudante = numEstudante;
            Name = name;
            Nif = nif;
            Saldo = saldo;
        }
    }
}
