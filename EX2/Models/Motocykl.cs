using System;
using System.Threading;


namespace EX2.Models
{
    // Dodaj klasy reprezentujące motocykl, autobus i ciężarówke, które dziedziczą po klasie Vehicle.

    class Motocykl : Vehicle
    {
        public override void MakeSound()
        {
            Console.Beep();
            Thread.Sleep(200);
            Console.Beep();
        }
    }
}



