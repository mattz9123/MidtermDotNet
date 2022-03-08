using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class Camry : RaceCar
    {
        public Camry()
        {
            Name = "Camry";
            TopSpeed = 120;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} engine sounds terrible!");
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name} slows down!");
            base.Brake();
        }
    }
}
