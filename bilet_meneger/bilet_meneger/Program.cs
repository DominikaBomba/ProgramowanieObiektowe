using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilet_meneger
{
    internal class Program
    {
        static void Main(string[] args)
            
        {
            List<Bilet> bilety = new List<Bilet>();
            List<Bilet_trybuna> bilety_t = new List<Bilet_trybuna>();
            int[,] miejsca_td = new int[20, 20];
            int[,] miejsca_tg = new int[20, 20];
            int[,] miejsca_p = new int[20, 20];
            int option = 1;
            List<Uczestnik> uczestnicy = new List<Uczestnik>();
            ShowMenu(bilety, bilety_t,uczestnicy, miejsca_td, miejsca_tg, miejsca_tg, option);


            Console.ReadKey();
        }
        private static void Dodaj(List<Bilet> bilety, List<Bilet_trybuna> bilet_t, List<Uczestnik> uczestnicy, int[,] miejsca_td, int[,] miejsca_tg, int[,] miejsca_p, int option)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Dodawanie biletu ");
            Console.ResetColor();
            //trybuna czy płyta
            
            do
            {
                Console.WriteLine("Wybierz sektor: \n 1. Plyta \n 2. Trybuna Dolna \n 3. Trybuna Górna");
            }while (!(int.TryParse(Console.ReadLine(), out option)) || option < 1 || option > 3);

            if(option == 1) //jeśli płyta inicjujemy obiekt klasy Bilet
            {
                Dodaj2(bilety, bilet_t, uczestnicy, miejsca_p, option);

            }
            else if(option == 2)
            {
                Dodaj2(bilety, bilet_t, uczestnicy, miejsca_td, option);
            }
            else
            {
                Dodaj2(bilety, bilet_t, uczestnicy, miejsca_tg, option);
            }
     
            
        }
        private static void Dodaj2(List<Bilet> bilety, List<Bilet_trybuna> bilet_t, List<Uczestnik> uczestnicy, int[,] miejsca, int option)
        {
            Console.WriteLine("Podaj imię uczestnika: ");
            string imie = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko: ");
            string nazwisko = Console.ReadLine();

            int rok_urodzenia;
            do
            {
                Console.WriteLine("Podaj rok urodzenia : ");
            } while (!(int.TryParse(Console.ReadLine(), out rok_urodzenia)));



            Random r = new Random();
            int nowe_id_u = r.Next(1000, 9999); //id uczestnika 
            int nowe_id_b = r.Next(1000, 9999); //id biletu
                                                //dodanie uczestnika
            Uczestnik nowy_uczestnik = new Uczestnik(nowe_id_u, imie, nazwisko, (short)(DateTime.Now.Year - rok_urodzenia));
            uczestnicy.Add(nowy_uczestnik);
            //dodanie biletu
            int rzad;
            int kolumna;
            ShowPlaces(miejsca, option);
            do
            {
                do
                {
                    Console.WriteLine("wybierz rząd: ");
                } while (!(int.TryParse(Console.ReadLine(), out rzad)) || rzad < 0 || rzad > miejsca.GetLength(0));

                do
                {
                    Console.WriteLine("wybierz kolumnę: ");
                } while (!(int.TryParse(Console.ReadLine(), out kolumna)) || kolumna < 0 || rzad > miejsca.GetLength(1));
                if(miejsca[rzad - 1, kolumna - 1] != 0)
                {
                    Console.WriteLine("!!! Miejsce zajęte !!!");
                }
            } while (miejsca[rzad - 1, kolumna - 1] != 0);

            Bilet nowy_bilet = new Bilet(nowe_id_b, nowe_id_u, (miejsce)option, rzad - 1, kolumna - 1);
            miejsca[rzad - 1, kolumna - 1] = nowe_id_b;
            bilety.Add(nowy_bilet);
        }
        private static void ShowInfo(List<Bilet> bilety, List<Bilet_trybuna> bilet_t, List<Uczestnik> uczestnicy)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Wyszukiwanie biletu ");
            Console.ResetColor();
            Console.WriteLine("Podaj nazwisko uczestnika: ");
            string nazwisko = Console.ReadLine();
            int id_uczestnika = 0;
            foreach (Uczestnik u in uczestnicy)
            {
                if(u.Nazwisko == nazwisko)
                {
                    Console.WriteLine(u.Informacje());
                     id_uczestnika = u.Id;
                    foreach(Bilet b in bilety)
                    {
                        if(b.Id_uczestnika == id_uczestnika)
                        {
                            Console.WriteLine(b.Informacje());
                        }
                    }
                    
                }

            }
            if (id_uczestnika == 0)
            {
                Console.WriteLine($"Nie znaleziono uczestnika {nazwisko}");
            }
        }
        private static void ShowPlaces(int[,] tablica, int option)
        {
            Console.WriteLine($"Miejsca na {(miejsce)option}");
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Write("     ");
            Console.ForegroundColor= ConsoleColor.Blue;
            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                Console.Write($"{i + 1}".PadRight(3, ' '));
            }
            Console.ResetColor();
            Console.WriteLine(" ");

            for (int i = 0; i < tablica.GetLength(0); i++){
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"{i+1}".PadRight(4, ' '));
                Console.ResetColor();
                for (int j=0; j< tablica.GetLength(1); j++)
                {
                    
                    if(tablica[i,j] == 0)
                    {
                        Console.Write(" \u25a1 ");
                    }
                    else
                    {
                        Console.Write(" \u25a0 ");
                    }
                   
                }
                Console.WriteLine("");
            }
        }
        private static void ShowMenu(List<Bilet> bilety, List<Bilet_trybuna> bilet_t, List<Uczestnik> uczestnicy, int[,] miejsca_td, int[,] miejsca_tg, int[,] miejsca_p, int option)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Wybierz opcje: ");
                Console.WriteLine("1. Dodawanie uczestnika wydarzenia");
                Console.WriteLine("2. Wyszukiwanie uczestnika");
                Console.WriteLine("3. Wyświetlanie stanu miejsc (zajęte/ niezajęte)");
                Console.WriteLine("4. Zakończ program");
                switch (Console.ReadLine())
                {
                    case "1":
                        Dodaj(bilety,bilet_t, uczestnicy, miejsca_td,miejsca_tg, miejsca_p, option);
                        break;
                    case "2":
                        ShowInfo(bilety, bilet_t, uczestnicy);
                        break;
                    case "3":
                       
                        do
                        {
                            Console.WriteLine("Wybierz sektor: \n 1. Plyta \n 2. Trybuna Dolna \n 3. Trybuna Górna");
                        } while (!(int.TryParse(Console.ReadLine(), out option)) || option < 1 || option > 3);
                        if(option == 0)
                        {
                            ShowPlaces(miejsca_p, 1);
                        }
                        else if (option == 1)
                        {
                            ShowPlaces(miejsca_td, 2);
                        }
                        else
                        {
                            ShowPlaces(miejsca_tg, 3);
                        }
                        break;


                }
                Console.ReadKey();
            } while (true);
        }
    }
}
