using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Modelo
{
    internal class Prato
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public TipoPrato Tipo { get; set; }
        public bool Ativo { get; set; }

        public enum TipoPrato
        {
            Carne,
            Peixe,
            Vegetariano
        }

        public Prato()
        {
        }

        public Prato(string descricao, TipoPrato tipo, bool ativo)
        {
            Descricao = descricao;
            Tipo = tipo;
            Ativo = ativo;
        }
    }
}
