using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicDelegateProblem
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
        public delegate void CarEngineHandler(string msgForCaller);

        //  Define a member variable of this delegate.
        //  Now a public member!
        public CarEngineHandler listOfHandlers;

        //  Add registration function for the caller.
        public void RegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            listOfHandlers += methodToCall;
        }

        public void UnRegisterWithCarEngine(CarEngineHandler methoToCall)
        {
            listOfHandlers -= methoToCall;
        }

        //  Implement the Accelerate() method to invoke the delegate's
        //  invocation list under the correct circumstatnces.
        public void Accelerate(int delta)
        {
            //  If the car is "dead", send dead message.
            if(carIsDead)
            {
                if(listOfHandlers != null)
                    listOfHandlers("Sorry, this car is dead...");
            }
            else
            {
                CurrentSpeed += delta;

                //  Is the car "almost dead"?
                if (10 == (MaxSpeed - CurrentSpeed) && listOfHandlers != null)
                {
                    listOfHandlers("Careful buddy! Gonna blow!");
                }
                if (CurrentSpeed >= MaxSpeed)
                    carIsDead = true;
                else
                    Console.WriteLine("CurrentSpeed = {0}", CurrentSpeed);
            }
        }
    }
}
