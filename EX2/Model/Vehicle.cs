using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EX2.Model
{
    // Utwórz abstrakcyjną klasę Vehicle, która będzie miała przynajmniej te 2 pola -> typ pojazdu i kolor (można dodać więcej niż 2 pola).
    abstract class Vehicle
    {
        public string typ { get; set; }
        public string kolor { get; set; }
        public virtual void PresentVehicle()
        {

            Console.WriteLine($"Hi, I'm a {kolor} car and I will make no sound");
        }

        public abstract void MakeSound();
    }

    // Dodaj klasy reprezentujące motocykl, autobus i ciężarówke, które dziedziczą po klasie Vehicle.

    class Motocykl : Vehicle
    {
        public override void MakeSound()
        {
            Console.Beep();
            Console.Beep();
        }
    }

    class Autobus : Vehicle
    {
        public override void MakeSound()
        {
            Console.Beep();
            Console.Beep();
            Console.Beep();
        }
    }

    class Ciezarowka : Vehicle
    {
        public override void MakeSound()
        {
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
        }
    }

    class Samochod : Vehicle
    {
        public string _model { get; set; }

        public int _rokProdukcji { get; set; }

        public Samochod(string model, int rokProdukcji)
        {
            _model = model;
            _rokProdukcji = rokProdukcji;
        }
        public void GetSamochodDetails()
        {
            Console.WriteLine($"Model: {_model}, RokProdukcji: {_rokProdukcji}");
        }

        public override void MakeSound()
        {
            Console.Beep();
        }
    }
}



