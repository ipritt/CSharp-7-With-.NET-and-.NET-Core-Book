using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class MotorCycle
    {
        public int driverIntensity;
        //  New members to represent the name of the driver.
        //public string name;
        //  change 'name' to 'driverName' to eliminate need for 'this' keyword
        public string driverName;

        //  If you create a custom constructor, the default
        //  constructor will be removed.
        //  Put back the default constructor, which will
        //  set all data members to default values.
        //  The default can also be customized as in the 'Car' class.
        //public MotorCycle() { Console.WriteLine("In default ctor"); }

        //  Constructor chaining using 'this' keyword.
        //public MotorCycle(int intensity)
        //    : this(intensity, "") { Console.WriteLine("In ctor taking an int"); }
        //public MotorCycle(string name)
        //    : this(0, name) { Console.WriteLine("In ctor taking a string"); }
        ////  This is them master ctor that does all the real work.
        //public MotorCycle(int intensity, string name)
        //{
        //    Console.WriteLine("In master ctor");
        //    if(intensity > 10)
        //    {
        //        intensity = 10;
        //    }
        //    driverIntensity = intensity;
        //    driverName = name;
        //}

        //  Our custom constructor.
        //public MotorCycle(int intensity)
        //{
        //    driverIntensity = intensity;
        //}

        //  Redundant constructor logic!
        //public MotorCycle(int intensity)
        //{
        //    //if(intensity > 10)
        //    //{
        //    //    intensity = 10;
        //    //}
        //    //driverIntensity = intensity;
        //    SetIntensity(intensity);
        //}
        //  Redundant 'intensity' code here!
        //public MotorCycle(int intensity, string name)
        //{
        //    //if(intensity > 10)
        //    //{
        //    //    intensity = 10;
        //    //}
        //    //driverIntensity = intensity;
        //    SetIntensity(intensity);
        //    driverName = name;
        //}
        //  Could use a method to handle 'intensity' logic
        //  But still leaves redundancy in constructors
        //  from both of them calling the same method to handle it
        //public void SetIntensity(int intensity)
        //{
        //    if (intensity > 10)
        //    {
        //        intensity = 10;
        //    }
        //    driverIntensity = intensity;
        //}
        //  Single contructor using optional args
        //  Available from .NET 4.0 and up.
        public MotorCycle(int intensity = 0, string name = "")
        {
            if (intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
            driverName = name;
        }

            public void PopAWheely()
        {
            for (int i = 0; i < driverIntensity; i++)
            {
                Console.WriteLine("Yeeeeeee Haaaaaeewwww!");
            }
        }

        //  Use 'this' keyword to tell compiler to use
        //  current instance member variable 'name'
        //  instead of incoming parameter 'name'
        //  which it does because it is local to this method.
        public void SetDriverName(string name)
        {
            //name = name;
            //this.name = name;
            //driverName = name;
            // same as this.driverName = name;
            //  'This' is little use in unambiguous situations
            //  but will enable intellisense for member variables.
            this.driverName = name;
        }
    }
}
