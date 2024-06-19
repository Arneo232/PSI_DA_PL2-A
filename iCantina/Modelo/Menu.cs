using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Modelo
{
    internal class Menu
    {
        public int Id { get; set; }
        public DateTime DataHora { get; set; }
        public int QntDisp { get; set; }
        public float PrecoEst { get; set; }
        public float PrecoProf { get; set; }
        public List<Extra> Extras { get; set; }
        public List<Prato> Pratos { get; set; }

        public Menu()
        {
        }

        public Menu(DateTime dataHora, int qntDisp, float precoEst, float precoProf)
        {
            DataHora = dataHora;
            QntDisp = qntDisp;
            PrecoEst = precoEst;
            PrecoProf = precoProf;
            this.Extras = new List<Extra>();
            this.Pratos = new List<Prato>();
        }
    }
}
