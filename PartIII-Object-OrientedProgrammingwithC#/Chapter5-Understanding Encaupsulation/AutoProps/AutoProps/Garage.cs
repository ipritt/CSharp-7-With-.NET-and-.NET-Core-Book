using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProps
{
    class Garage
    {
        //  Must use the contructors to override default
        //  values assigned to hidden backing fields.
        //  Initializing backing fields with C#6 eliminates need
        //  for extra code in constructors to do so.
        //public Garage()
        //{
        //    MyAuto = new Car();
        //    NumberOfCars = 1;
        //}
        public Garage() { }
        public Garage(Car car, int number)
        {
            MyAuto = car;
            NumberOfCars = number;
        }

        //  The hidden int backing field is set to zero!
        //  With C#6 can initialize
        public int NumberOfCars { get; set; } = 1;

        //  The hidden Car backing field is set to null!
        //  With C#6 can initialize
        public Car MyAuto { get; set; } = new Car();
    }
}
