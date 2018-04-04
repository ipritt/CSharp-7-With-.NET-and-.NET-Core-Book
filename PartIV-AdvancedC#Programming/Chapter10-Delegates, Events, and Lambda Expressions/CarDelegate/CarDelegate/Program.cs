using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Delegates are event enablers *****\n");

            //  First, make a Car object.
            Car c1 = new Car("Slug Bug", 100, 10);

            //  Now, tell the car which method to call
            //  when it wants to send is messages.
            c1.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));
            //  This time, hold onto the delegate object,
            //  so we can unregister later.
            Car.CarEngineHandler handler2 = new Car.CarEngineHandler(OnCarEngineEvent2);
            c1.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent2));


            //  Speed up(this will trigger the events).
            Console.WriteLine("***** Speeding up *****");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);

            //  Unregister from the second handler.
            c1.UnRegisterWithCarEngine(handler2);

            //  We won't see the "uppercase" message anymore!
            Console.WriteLine("***** Speeding up *****");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);
        }

        //  This is the targer for incomong events.
        public static void OnCarEngineEvent(string msg)
        {
            Console.WriteLine("\n***** Message From Car Object *****");
            Console.WriteLine("=> {0}", msg);
            Console.WriteLine("**************************\n");
        }

        public static void OnCarEngineEvent2(string msg)
        {
            Console.WriteLine("=> {0}", msg.ToUpper());
        }
    }
}
