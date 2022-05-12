using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EX2.Models;

namespace EX2
{

    
    internal class Garaz
    {
        public string _nazwa { get; set; }
        public int _iloscMiejscParkingowych { get; set; }
        public List<Samochod> samochody { get; set; }

        public Garaz()
        {
            samochody = new List<Samochod>();
        }
        public void GetGarazDetails()
        {
            Console.WriteLine($"Nazwa garazu: {_nazwa}, ilosc miejsc parkingowych: {_iloscMiejscParkingowych}");
        }

        public void AddVehicle()
        {
            samochody.Add();
        }
    }
}
