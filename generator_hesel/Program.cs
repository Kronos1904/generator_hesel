using System;
using System.IO;

namespace generator_hesel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("zadejte délku hesla: ");
            int delkaHesla = Convert.ToInt32(Console.ReadLine());//velikost zadaná uživatelem

            Random rand = new Random();//generátor náhodných čísel

            string filepath = @"C:\Users\jan.sindler\Desktop\heslo\heslo.txt";//cesta

            string abeceda = "abcdefghijklmnopqrstuvwxyz";
            string cisla = "123456789";
            string abecedaCisla = "abcdefghijklmnopqrstuvwxyz123456789";//znaky do hesla

            string vygenerovatHeslo = "";//proměnná do které vložíme heslo

            Console.WriteLine("Chcete aby heslo obsahovalo čísla nebo písmena");
            string rozhodnuti = Console.ReadLine();//rozhodnutí uživatele z čeho chce mít heslo složené

            int delkaabecedy = abeceda.Length;
            int delkacisla = cisla.Length;
            int delkaAbecedaCisla = abecedaCisla.Length;//délky které se použíjí na char a 


            Console.WriteLine("Vaše heslo \n ");
            switch (rozhodnuti)//switch s cykly
            {
                case "čísla"://čísla
                    {
                        for (int i = 0; i < delkaHesla; i++)
                        {
                            int cislo = rand.Next(0, delkacisla);
                            char a = cisla[cislo];
                            Console.Write(a);
                            vygenerovatHeslo += a;
                        }//cyklus na vypsání číselného hesla
                        File.AppendAllText(filepath, vygenerovatHeslo);
                        break;
                    }
                case "písmena"://písmena
                    {
                        for (int i = 0; i < delkaHesla; i++)
                        {
                            int cislo = rand.Next(0, delkaabecedy);
                            char a = abeceda[cislo];
                            Console.Write(a);
                            vygenerovatHeslo += a;
                        }//cyklus na vypsání píssemného hesla
                        File.AppendAllText(filepath, vygenerovatHeslo);
                        break;
                    }
                case "obojí"://čísla i písmena
                    {
                        for (int i = 0; i < delkaHesla; i++)
                        {
                            int cislo = rand.Next(0, delkaAbecedaCisla);
                            char a = abecedaCisla[cislo];
                            Console.Write(a);
                            vygenerovatHeslo += a;
                        }//cyklus na vypsání hesla, které obsahuje čísla i písmena
                        File.AppendAllText(filepath, vygenerovatHeslo);
                        break;
                    }

            }
            Console.ReadKey();
        }
    }
}
