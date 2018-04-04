using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMultipleExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Handling Multiple Exceptions *****\n");

            Car myCar = new Car("Rusty", 90);
            myCar.CrankTunes(true);
            try
            {
                //  Trip Arg out of range exception.
                //myCar.Accelerate(-10);
                myCar.Accelerate(20);
            }
            //  Processes first approprate catch so
            //  CarIsDeadException and ArgumentOutOfRangeException
            //  are unreachealbe wehn Exception can handle anything
            //  derived from System.Exception.
            //catch(Exception e)
            //{
            //    //  Process all other exceptions?
            //    Console.WriteLine(e.Message);
            //}
            catch (CarIsDeadException e) when(e.ErrorTimeStamp.DayOfWeek != DayOfWeek.Friday)
            {
                Console.WriteLine("Catching car is dead!");
                Console.WriteLine(e.Message);
                //  Do any partial processing of this error and
                //  pass the buck...Rethrow.
                //throw;
                //try
                //{
                //    //  Attempt to open a file name carError.txt on the C drive.
                //    FileStream fs = File.Open(@"C:\carErrors.txt", FileMode.Open);
                //}
                //catch (Exception e2)
                //{
                //    //  Throw an exception that records the new exception, 
                //    //  as well as the message of the first exception.
                //    throw new CarIsDeadException(e.Message, e2);
                //}
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            //  Always catch most derived(specific) exceptions first
            //  to least derived(general) last.
            //catch (Exception e)
            //{
            //    //  Process all other exceptions?
            //    Console.WriteLine(e.Message);
            //}
            //  A general catch.
            catch
            {
                Console.WriteLine("Something bad happened...");
            }
            finally
            {
                //  This will always occur. Exception or not.
                myCar.CrankTunes(false);
            }
        }
    }
}
