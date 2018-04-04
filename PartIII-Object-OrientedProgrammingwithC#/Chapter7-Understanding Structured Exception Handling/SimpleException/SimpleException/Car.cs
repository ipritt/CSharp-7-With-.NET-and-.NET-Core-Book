using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleException
{
    class Car
    {
        //  Constant for maximum speed.
        public const int MaxSpeed = 100;

        //  Car properties.
        public int CurrSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";

        //  Is the car still operational?
        private bool carIsDead;

        //  A car has-a radio.
        private Radio theMusicBox = new Radio();

        //  Constructors.
        public Car(){ }
        public Car(string name, int speed)
        {
            CurrSpeed = speed;
            PetName = name;
        }

        public void CrankTunes(bool state)
        {
            //  Delegate request to inner object.
            theMusicBox.TurnOn(state);
        }

        //  See if the Car has overheated.
        public void Accelerate(int delta)
        {
            if(carIsDead)
                Console.WriteLine("{0} is out of order...", PetName);
            else
            {
                CurrSpeed += delta;
                if(CurrSpeed > MaxSpeed)
                {
                    //Console.WriteLine("{0} has overheated!", PetName);
                    CurrSpeed = 0;
                    carIsDead = true;

                    //  We need to call the HelpLink property, thus we need to
                    //  create a local variable before throwing the Exception object.
                    Exception ex = new Exception($"{PetName} has overheated!");
                    ex.HelpLink = "http://www.CarsRUs.com";

                    //  Stuff in custom data regarding the error.
                    ex.Data.Add("TimeStamp", $"The car exploded at {DateTime.Now}");
                    ex.Data.Add("Cause", "You have a lead foot.");
                    throw ex;

                    //  Use the "throw" keyword to raise an exception.
                    //throw new Exception($"{PetName} has overheated!");
                }
                else
                    Console.WriteLine("=> CurrentSpeed = {0}", CurrSpeed);
            }
        }
    }
}
