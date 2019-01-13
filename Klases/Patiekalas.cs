using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsipirkimoSkaiciuokle
{
    class Patiekalas
    {
        public string Pavadinimas { get; set; }
        public List<Ingridientas> Ingridientai { get; set; }
        

        public Patiekalas(string pavadinimas, List<Ingridientas> ingridientai)
        {
            Pavadinimas = pavadinimas;
            Ingridientai = ingridientai;
            
        }
    }

    
}
