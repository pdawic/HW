using System;
using System.Collections.Generic;

namespace EX2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nazwaTmp, modelTmp;
            int rokTmp, iloscMiejscParkingowychTmp;
            var samochodList = new List<Samochod>();
            

            Console.WriteLine("Czołem użytkowniku, wprowadź dane swojego garażu. Proszę podać nazwę:");
            nazwaTmp = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("Dziękuje za podanie nazwy. Proszę podaj ile maksymalnie pomieści on samochodów.");
                bool success = int.TryParse(Console.ReadLine(), out iloscMiejscParkingowychTmp);
                if (!success)
                {
                    Console.WriteLine("Zły format danych");
                    continue;
                }
                break;
            }
            Garaz garaz = new Garaz(nazwaTmp, iloscMiejscParkingowychTmp);
            //garaz.GetGarazDetails();

            for (int i = 1; i <= iloscMiejscParkingowychTmp; i++)
            {
                Console.WriteLine($"Proszę podać dane samochodu nr {i}", i);
                modelTmp = Console.ReadLine();

                while (true)
                {
                    Console.WriteLine("Podaj rok produkcji samochodu (1885 - 2022):  ");
                    bool success = int.TryParse(Console.ReadLine(), out rokTmp);
                    if (!success)
                    {
                        Console.WriteLine("Zły format danych");
                        continue;
                    }
                    if (rokTmp <= 1884 || rokTmp >= 2023)
                    {
                        Console.WriteLine("Podaj liczbę z zakresu 1885 - 2022.");
                        continue;
                    }

                    break;
                }
                Samochod samochod = new Samochod(modelTmp, rokTmp);
                samochodList.Add(samochod);
                //samochod.GetSamochodDetails();

            }

            Console.Clear();
            Console.WriteLine($"Dziękuje za wszystkie dane. Oto utworzony garaż z samochodami:");
            garaz.GetGarazDetails();
            Console.WriteLine($"Samochody w garażu:");

            foreach (var samochod in samochodList)
            {
                samochod.GetSamochodDetails();
                Console.WriteLine();
            }
        }
    }
}
