using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilet_meneger
{
    internal class Bilet_trybuna : Bilet
    {
        public bool Czy_siedzenie {  get; set; }

        public Bilet_trybuna(int id, int id_uczestnika, miejsce miejsce, int rzad, int kolumna, bool czy_siedzenie) : base(id, id_uczestnika, miejsce, rzad, kolumna)
        {
           Czy_siedzenie = czy_siedzenie;
        }
        public override string Informacje()
        {
            return base.Informacje() + $"Rząd {Rzad + 1}, Miejsce {Kolumna + 1}";
        }
    }
}
