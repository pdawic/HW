using System;


namespace EX2.Models
{
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
            MakeSound();
        }

        public override void MakeSound()
        {
            Console.Beep();
        }
    }
}



