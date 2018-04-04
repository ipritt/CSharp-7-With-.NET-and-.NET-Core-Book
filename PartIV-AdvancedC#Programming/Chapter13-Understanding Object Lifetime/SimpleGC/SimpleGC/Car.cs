using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGC
{
    //  Car.cs
    public class Car
    {
        public int CurrSpeed { get; set; }
        public string PetName { get; set; }

        public Car() { }
        public Car(string name, int speed)
        {
            PetName = name;
            CurrSpeed = speed;
        }

        public override string ToString()
        {
            return $"{PetName} is going {CurrSpeed} MPH.";
        }
    }
}
