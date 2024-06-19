using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Modelo
{
    internal class Reserva
    {
        public int Id { get; set; }
        public DateTime DataReserva { get; set; }
        public Cliente Cliente { get; set; }
        public Multa Multa { get; set; }
        public Prato Prato { get; set; }
        public Extra Extra { get; set; }
        public Menu Menu { get; set; }

        public Reserva()
        {
        }

        public Reserva(DateTime dataReserva, Cliente cliente, Multa multa, Prato prato, Extra extra, Menu menu)
        {
            DataReserva = dataReserva;
            Cliente = cliente;
            Multa = multa;
            Prato = prato;
            Extra = extra;
            Menu = menu;
        }
    }
}
