using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2
{

    
    internal class Garaz
    {
        public string _nazwa { get; set; }
        public int _iloscMiejscParkingowych { get; set; }

        public Garaz(string nazwa, int iloscMiejscParkingowych)
        {
            _nazwa = nazwa;
            _iloscMiejscParkingowych = iloscMiejscParkingowych;
        }
        public void GetGarazDetails()
        {
            Console.WriteLine($"Nazwa garazu: {_nazwa}, ilosc miejsc parkingowych: {_iloscMiejscParkingowych}");
        }
    }
}
