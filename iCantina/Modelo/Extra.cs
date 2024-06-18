using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static iCantina.Modelo.Prato;

namespace iCantina.Modelo
{
    internal class Extra
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public float Preco { get; set; }
        public bool Ativo { get; set; }

        public Extra()
        {
        }

        public Extra(string descricao, float preco, bool ativo)
        {
            Descricao = descricao;
            Preco = preco;
            Ativo = ativo;
        }
    }
}
