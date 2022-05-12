using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EX2.Models
{
    // Utwórz abstrakcyjną klasę Vehicle, która będzie miała przynajmniej te 2 pola -> typ pojazdu i kolor (można dodać więcej niż 2 pola).
    abstract class Vehicle
    {
        public string typ { get; set; }
        public string kolor { get; set; }

        //public virtual void PresentVehicle()
        //{

        //    Console.WriteLine($"Typ pojazdu {typ}, kolor {kolor}");
        //    MakeSound();
        //}

        public abstract void MakeSound();
    }
}



