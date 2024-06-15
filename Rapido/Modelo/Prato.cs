using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rapido.Modelo
{
    internal class Prato
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TypePrato Tipo { get; set; }

        public enum TypePrato
        {
            a, b, c
        }
    }
}
