using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilet_meneger
{
    enum miejsce
    {
        plyta = 1, trybuna_dolna = 2, trubuna_gorna = 3
    }
    internal class Bilet
    {
        public int Id { get; set; }
        public int Id_uczestnika { get; set; }
        public miejsce Miejsce { get; set; }

        public int Rzad { get; set; }
        public int Kolumna { get; set; }

        public Bilet(int id, int id_uczestnika, miejsce miejsce, int rzad, int kolumna)
        {
            Id = id;
            Id_uczestnika = id_uczestnika;
            Miejsce = miejsce;
            Rzad = rzad;
            Kolumna = kolumna;

        }
        public virtual string Informacje()
        {
            return $"Bilet nr.{Id}, miejsce na {Miejsce}, rząd {Rzad}, kolumna {Kolumna}";
        }

    }
}
