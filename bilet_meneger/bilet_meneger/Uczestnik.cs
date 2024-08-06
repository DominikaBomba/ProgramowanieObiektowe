using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilet_meneger
{
    internal class Uczestnik
    {
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public short Wiek {  get; set; }

        public Uczestnik(int id, string imie, string nazwisko, short wiek)
        {
            Id = id;
            Imie = imie;
            Nazwisko = nazwisko;
            Wiek = wiek;
        }
        public string Informacje()
        {
            return $"{Imie} {Nazwisko}, {Wiek} lat";
        }
    }
}
