using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsipirkimoSkaiciuokle
{
    class Skaiciuokle
    {
        public List<Patiekalas> PatiekaluSarasas { get; set; }
        

        public Skaiciuokle(List<Patiekalas> patiekaluSarasas)
        {
            PatiekaluSarasas = patiekaluSarasas;
            
        }

        public Skaiciuokle()
        {

        }

        public List<Ingridientas> SuskaiciuotiProduktus()
        {
            //SURASO VISUS NAUDOJAMUS PRODUKTUS IR ISRENKA UNIKALIUS
            List<string> naudojamiProduktai = new List<string>();
            foreach (var patiekalas in PatiekaluSarasas)
            {
                foreach (var ingridientas in patiekalas.Ingridientai)
                {
                    naudojamiProduktai.Add(ingridientas.Pavadinimas);
                }
            }
            List<string> unikalusProduktai = naudojamiProduktai.Distinct().ToList();

            //SURASSO VISUS NAUDOJAMUS MATAVIMO VIENETUS IR ISRENKA UNIKALIUS
            List<string> naudojamiVienetai = new List<string>();
            foreach (var patiekalas in PatiekaluSarasas)
            {
                foreach (var ingridientas in patiekalas.Ingridientai)
                {
                    naudojamiVienetai.Add(ingridientas.Vienetas);
                }
            }
            List<string> unikalusVienetai = naudojamiVienetai.Distinct().ToList();

            //UNIKALIEMS PRODUKTAMS PRISKIRIA UNIKALIUS MATAVIMO VIENETUS
            Dictionary<string, string> matavimoVienetai = new Dictionary<string, string>();
            foreach (var unikalusProduktas in unikalusProduktai)
            {
                string unikalusMatavimoVienetas = null;
                foreach (var patiekalas in PatiekaluSarasas)
                {
                    foreach (var ingridientas in patiekalas.Ingridientai)
                    {
                        if (unikalusProduktas == ingridientas.Pavadinimas)
                        {
                            unikalusMatavimoVienetas = ingridientas.Vienetas;
                        }
                    }
                }
                matavimoVienetai.Add(unikalusProduktas, unikalusMatavimoVienetas);
            }

            //SUSKAICIUOJA UNIKALIU PRODUKTU VISA SUMA IR PRISKIRIA UNIKALU MATAVIMO VIENETA
            List<Ingridientas> pirkiniuSarasas = new List<Ingridientas>();
            foreach (var unikalusProduktas in unikalusProduktai)
            {
                double suma = 0;
                foreach (var patiekalas in PatiekaluSarasas)
                {
                    foreach (var ingridientas in patiekalas.Ingridientai)
                    {
                        if (unikalusProduktas == ingridientas.Pavadinimas)
                        {
                            suma += ingridientas.Kiekis;
                        }
                    }
                }
                pirkiniuSarasas.Add(new Ingridientas(unikalusProduktas, suma=Math.Round(suma, 2, MidpointRounding.AwayFromZero), matavimoVienetai[unikalusProduktas]));
            }
            return pirkiniuSarasas;
        }
    }
}
