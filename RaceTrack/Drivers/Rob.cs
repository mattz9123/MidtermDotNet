using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaceTrack.RaceTrack.Cars;

namespace RaceTrack.RaceTrack.Drivers
{
    public class Rob : Driver
    {
        public Rob(RaceCar car) : base(car)
        {
            Name = " Rob";
            SkillLevel = 5;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }

        
    }
}
