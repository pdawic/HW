using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2
{
    internal class Samochod
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
    }
}
