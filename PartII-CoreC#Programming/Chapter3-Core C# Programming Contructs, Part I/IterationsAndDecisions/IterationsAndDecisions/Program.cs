using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationsAndDecisions
{
    class Program
    {
        static void Main(string[] args)
        {
            ForLoopExample();
            Console.WriteLine();
            ForEachLoopExample();
            Console.WriteLine();
            LinqQueryOverInts();
            Console.WriteLine();
            WhileLoopExample();
            Console.WriteLine();
            DoWhileLoopExample();
            Console.WriteLine();
            IfElseExample();
            Console.WriteLine();
            ExecuteIfElseusingConditionalOperator();
            Console.WriteLine();
            SwitchExample();
            Console.WriteLine();
            SwitchOnStringExample();
            Console.WriteLine();
            SwitchOnEnumExample();
            Console.WriteLine();
            ExecutePatternMatchingSwitch();
            Console.WriteLine();
            ExecutePatternMatchingSwitchWithWhen();

            Console.ReadLine();
        }

        //  A basic for loop.
        static void ForLoopExample()
        {
            //  Note! "i" is only visible within the scope of the for loop.
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("Number is: {0}", i);
            }
            //  "i" is not visible here.
        }

        static void ForEachLoopExample()
        {
            string[] carTypes = { "Ford", "BMW", "Yugo", "Honda" };
            foreach(string c in carTypes)
                Console.WriteLine(c);

            int[] myInts = { 10, 20, 30, 40 };
            foreach(int i in myInts)
                Console.WriteLine(i);
        }

        static void LinqQueryOverInts()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };

            //  Linq query!
            var subset = from i in numbers where i < 10 select i;
            Console.Write("Values in subset: ");
            foreach(var i in subset)
            {
                Console.Write("{0}", i);
            }
        }

        static void WhileLoopExample()
        {
            string userIsDone = "";

            //  Test on a lower-class copy of the string.
            while(userIsDone.ToLower() != "yes")
            {
                Console.WriteLine("In while loop");
                Console.Write("Are you donw? [yes][no]:");
                userIsDone = Console.ReadLine();
            }
        }

        static void DoWhileLoopExample()
        {
            string userIsDone = "";

            do
            {
                Console.WriteLine("In do/while loop");
                Console.Write("Are you done? [yes][no]:");
                userIsDone = Console.ReadLine();
            } while (userIsDone.ToLower() != "yes"); // Note the semicolon!
        }

        static void IfElseExample()
        {
            string stringData = "My textual data";
            //  This is illegal, given that Length returns an int, not a bool.
            //if (stringData.Length)
            //  Legal, as this resolves to either true or false.
            if(stringData.Length > 0)
            {
                Console.WriteLine("string is greater than 0 characters");
            }
            else
            {
                Console.WriteLine("string is not greater than 0 characters");
            }
            Console.WriteLine();
        }

        static void ExecuteIfElseusingConditionalOperator()
        {
            string stringData = "My textual data";
            Console.WriteLine(stringData.Length > 0 ? "string is greater than 0 characters"
                                                    : "string is not greater than 0 characters");
            Console.WriteLine();
        }

        static void SwitchExample()
        {
            Console.WriteLine("1 [c#], 2 [VB}");
            Console.Write("Please pick your language preference:");

            string langChoice = Console.ReadLine();
            int n = int.Parse(langChoice);

            switch (n)
            {
                case 1:
                    Console.WriteLine("Good choice, C# is a fine language.");
                    break;
                case 2:
                    Console.WriteLine("VB: OOP, multithreading, and more!");
                    break;
                default:
                    Console.WriteLine("Well...good luck with that!");
                    break;
            }
        }

        static void SwitchOnStringExample()
        {
            Console.WriteLine("C# or VB");
            Console.Write("Please pick your language preference:");

            string langChoice = Console.ReadLine();
            switch(langChoice)
            {
                case "C#":
                    Console.WriteLine("Good choice, C# is a fine language.");
                    break;
                case "VB":
                    Console.WriteLine("VB: OOP, multithreading, and more!");
                    break;
                default:
                    Console.WriteLine("Well...good luck with that!");
                    break;
            }
        }

        static void SwitchOnEnumExample()
        {
            Console.WriteLine("Enter your favorite day of the week:");
            DayOfWeek favDay;

            try
            {
                favDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek),Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Bad input!");
                return;
            }

            switch(favDay)
            {
                case DayOfWeek.Sunday:
                    Console.WriteLine("Football!");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("Another day, another dollar");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("At least it is not Monday");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("A fine day.");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Almost Friday...");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Yes, Friday rules!");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("Great day indeed.");
                    break;
            }
            Console.WriteLine();
        }

        static void ExecutePatternMatchingSwitch()
        {
            Console.WriteLine("1 [Integer(5)], 2 [String(\"Hi\")], 3 [Decimal(2.5)]");
            Console.Write("Please choose an option:");
            string userChoice = Console.ReadLine();
            object choice;
            //  This is a standard constant patter switch statement to set up the example.
            switch(userChoice)
            {
                case "1":
                    choice = 5;
                    break;
                case "2":
                    choice = "Hi";
                    break;
                case "3":
                    choice = 2.5;
                    break;
                default:
                    choice = 5;
                    break;
            }
            //  This is new the patter matching switch statement.
            switch (choice)
            {
                case int i:
                    Console.WriteLine("Your choice is an integer {0}.", i);
                    break;
                case string s:
                    Console.WriteLine("Your choice is a string {0}.", s);
                    break;
                case decimal d:
                    Console.WriteLine("Your choice is a decimal {0}.", d);
                    break;
                default:
                    Console.WriteLine("Your choice is something else");
                    break;
            }
            Console.WriteLine();
        }

        static void ExecutePatternMatchingSwitchWithWhen()
        {
            Console.WriteLine("1 [C#], 2 [VB]");
            Console.Write("Please pick your language preference: ");

            object langChoice = Console.ReadLine();
            var choice = int.TryParse(langChoice.ToString(), out int c) ? c : langChoice;

            switch (choice)
            {
                case int i when i == 2:
                case string s when s.Equals("VB", StringComparison.OrdinalIgnoreCase):
                    Console.WriteLine("VB: OOP, multithreading, and more!");
                    break;
                case int i when i == 1:
                case string s when s.Equals("C#", StringComparison.OrdinalIgnoreCase):
                    Console.WriteLine("Good choice, C# is a fine language.");
                    break;
                default:
                    Console.WriteLine("Well...good luck with that!");
                    break;
            }
            Console.WriteLine();
        }
    }
}
