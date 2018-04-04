using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithTuples
{
    class Program
    {
        static void Main(string[] args)
        {
            (string, int, string) values = ("a", 5, "c");
            //var values = ("a", 5, "c");

            Console.WriteLine($"First item: {values.Item1}");
            Console.WriteLine($"Second item: {values.Item2}");
            Console.WriteLine($"Third item: {values.Item3}");
            Console.WriteLine();

            //  Can name the properties on either right or left side of statement.
            (string FirstLetter, int TheNumber, string SecondLetter) valuesWithNames = ("a", 5, "c");
            var valuesWithNames2 = (FirstLetter: "a", TheNumber: 5, SecondLetter: "c");

            Console.WriteLine($"First item: {valuesWithNames.FirstLetter}");
            Console.WriteLine($"Second item: {valuesWithNames.TheNumber}");
            Console.WriteLine($"Third item: {valuesWithNames.SecondLetter}");
            Console.WriteLine();
            //  Using the item notation still works!
            Console.WriteLine($"First item: {valuesWithNames.Item1}");
            Console.WriteLine($"Second item: {valuesWithNames.Item2}");
            Console.WriteLine($"Third item: {valuesWithNames.Item3}");
            Console.WriteLine();

            Console.WriteLine($"First item using right side and var: {valuesWithNames2.FirstLetter}");
            Console.WriteLine($"Second item using right side and var: {valuesWithNames2.TheNumber}");
            Console.WriteLine($"Third item using right side and var: {valuesWithNames2.SecondLetter}");

            //  When setting names on right, must use var keyword.
            //  Setting data types specifically (even without custom names)
            //  triggers compiler to use left side, assign properties using
            //  ItemX notation, and ignore any custom names set on right.
            //  The following two examples ignore the Custom1 and Custom2 names:
            (int, int) example = (Custom1: 5, Custom2: 7);
            (int Field1, int Field2) example1 = (Custom1: 5, Custom2: 7);
            //  The custom field names exist only at compile time and aren't
            //  available when inspecting the tuple at runtime using reflection.

            //  C# 7.1 has the ability to infer the variable names of tuples under
            //  certain conditions.
            Console.WriteLine("=> Inferred Tuple Names");
            var foo = new { Prop1 = "first", Prop2 = "second" };
            var bar = (foo.Prop1, foo.Prop2);
            Console.WriteLine($"{bar.Prop1};{bar.Prop2}");

            var samples = FillThesevalues();
            Console.WriteLine($"Int is: {samples.a}");
            Console.WriteLine($"String is: {samples.b}");
            Console.WriteLine($"Boolean is: {samples.c}");

            var (first, _, last) = SplitNames("Phillip F Japikse");
            Console.WriteLine($"{first}:{last}");

            Point p = new Point(7, 5);
            var pointValues = p.Deconstruct();
            Console.WriteLine($"X is: {pointValues.XPos}");
            Console.WriteLine($"Y is: {pointValues.YPos}");

            Console.ReadLine();
        }

        static (int a, string b, bool c) FillThesevalues()
        {
            return (9, "Enjoy your string", true);
        }

        static (string first, string middle, string last) SplitNames(string fullName)
        {
            //  do what is needed to split the name apart
            return ("Phillip", "F", "Japikse");
        }
    }

    struct Point
    {
        //  Fields of the structure.
        public int X;
        public int Y;

        //  A custom contructor.
        public Point(int XPos, int YPos)
        {
            X = XPos;
            Y = YPos;
        }

        public (int XPos, int YPos) Deconstruct() => (X, Y);
    }
}
