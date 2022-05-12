using System;
using System.Threading;


namespace EX2.Models
{
    class Ciezarowka : Vehicle
    {
        public override void MakeSound()
        {
            Console.Beep();
            Thread.Sleep(200);
            Console.Beep();
            Thread.Sleep(200);
            Console.Beep();
            Thread.Sleep(200);
            Console.Beep();
        }
    }
}



