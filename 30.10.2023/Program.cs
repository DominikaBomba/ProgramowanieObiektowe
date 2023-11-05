using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._10._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj 2 liczby: ");
            bool isCorrect = false;
            do
            {
                try
                {
                    string s = "asdfghj";
                    int n;
                    bool z;
                    z = int.TryParse(s, out n);
                    if (z == true)
                    {
                        Console.WriteLine("fajnie");
                    }
                    else
                    {
                        Console.WriteLine("Kiepsko");
                    }
                    Console.WriteLine("Podaj x: ");
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj y: ");
                    int y = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Iloraz {x / y}");
                    isCorrect = true;


                }
                catch (FormatException f)
                {
                    Console.WriteLine($"błąd: {f.Message}");

                }
                catch (OverflowException of)
                {

                    Console.WriteLine($"błąd przekroczono zakres: {int.MinValue} - {int.MaxValue}");


                }
                catch (DivideByZeroException dv)
                {
                    ErrorColorChange(dv.Message);

                }
                catch (Exception ex)
                {

                    ErrorColorChange($"{ex.Message}");

                }
                finally
                {
                    Console.WriteLine("Koniec");
                }


            } while (!isCorrect);
            
            Console.ReadKey();
        }
        static void ErrorColorChange(string message) { 
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Błąd: {message}");
            Console.ResetColor();
                }
    }
}
