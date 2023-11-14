using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _13._11._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] tab1 = new int[3];
            for(int i = 0; i < tab.Length; i++) {
                tab[i] = i;
            }

            for(int i = 0;i < tab.Length; i++) {
                Console.WriteLine(tab[i] + " ");
            }
            
            funkcja statyczna do ustawiania, wyslwietlania, do utworzenia tablicy
            */

            int[] tabA = tworzenie("tablicy");
            ustawianie(tabA, "tablica");
            wyswietlanie(tabA);
            Console.ReadKey();

        }

        public static int[] tworzenie(string name)
        {
            int size = 0;
            try
            {
                Console.WriteLine("Podaj rozmiar tablicy {0}: ", name);
                size = int.Parse(Console.ReadLine());
                if (size <= 0) throw new ArgumentException("Rozmiar tablicy musi być dodatni");
                
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine("Wystąpił błąd {0}", 2ex.Message);
                return null;
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Wystąpił błąd {0}", ex.Message);
                return null;
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Wystąpił błąd {0}", ex.Message);
                return null;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Wystąpił błąd {0}", ex.Message);
                return null;

            }
            int[] array = new int[size];
            return array;
        }
        public static int[] ustawianie(int[] array, string name)
        {
            bool correct = false;
            try
            {
                if (array != null && array.Length != 0) {
                    for (int i = 0; i < array.Length; i++)
                    {
                        do
                        {
                            Console.WriteLine("Podaj wartość  array[{0}], tablicy {1}: ", i, name);
                            correct = int.TryParse(Console.ReadLine(), out array[i]);

                        } while (!correct);
                    }
                }
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Wystąpił błąd {0}: ", e.Message);
            }
            catch (Exception e) {
                Console.WriteLine("Wystąpił błąd {0}: ", e.Message);
            }
            return (array);
        }
            
        public static void wyswietlanie(int[] array)
        {
            if (array != null && array.Length != 0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
            }
            Console.WriteLine("Dziękujemy za skorzystanie z programu");

        }
    }
}
