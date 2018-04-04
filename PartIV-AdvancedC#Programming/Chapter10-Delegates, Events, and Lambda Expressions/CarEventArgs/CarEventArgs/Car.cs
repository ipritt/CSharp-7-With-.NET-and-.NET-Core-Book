using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarEventArgs
{
    class Car
    {
        //  Internal state data.
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public string PetName { get; set; }

        //  Is the car alive or dead?
        private bool carIsDead;

        //  Class constructors.
        public Car() { }
        public Car(string name, int maxSp, int currSp)
        {
            CurrentSpeed = currSp;
            MaxSpeed = maxSp;
            PetName = name;
        }

        //  Define a delegate type.
        //public delegate void CarEngineHandler(string msg);
        //  using Event args
        public delegate void CarEngineHandler(object sender, CarEventArgs e);

        //  This car can send these events.
        public event CarEngineHandler Exploded;
        public event CarEngineHandler AboutToBlow;

        //  Define a member variable of this delegate.
        //private CarEngineHandler listOfHandlers;

        //  Add registration function for the caller.
        //public void RegisterWithCarEngine(CarEngineHandler methodToCall)
        //{
        //    listOfHandlers += methodToCall;
        //}

        //public void UnRegisterWithCarEngine(CarEngineHandler methoToCall)
        //{
        //    listOfHandlers -= methoToCall;
        //}

        //  Implement the Accelerate() method to invoke the delegate's
        //  invocation list under the correct circumstatnces.
        public void Accelerate(int delta)
        {
            //  If the car is "dead", send dead message.
            if(carIsDead)
            {   //  Can use null conditional operator.
                //  Must explicitly call invoke when doing so.
                //if(Exploded != null)
                    //Exploded?.Invoke("Sorry, this car is dead...");
                    //  Using EventArgs
                    Exploded?.Invoke(this, new CarEventArgs("Sorry, this car is dead..."));
            }
            else
            {
                CurrentSpeed += delta;

                //  Can use null conditional operator
                //  Must explicitly call Invoke when doing so.
                //  Is the car "almost dead"?
                if (10 == (MaxSpeed - CurrentSpeed))// && AboutToBlow != null)
                {
                    //AboutToBlow?.Invoke("Careful buddy! Gonna blow!");
                    //  Using EventArgs
                    AboutToBlow?.Invoke(this, new CarEventArgs("Careful buddy! Gonna blow!"));
                }
                if (CurrentSpeed >= MaxSpeed)
                    carIsDead = true;
                else
                    Console.WriteLine("CurrentSpeed = {0}", CurrentSpeed);
            }
        }
    }
}
