using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsipirkimoSkaiciuokle
{
    class Ingridientas
    {
        public string Pavadinimas { get; set; }
        public double Kiekis { get; set; }
        public string Vienetas { get; set; }

        public Ingridientas(string pavadinimas, double kiekis, string vienetas)
        {
            Pavadinimas = pavadinimas;
            Kiekis = kiekis;
            Vienetas = vienetas;
        }
    }
}
