using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicStringFunctionality();
            StringConcatenation();
            EscapeChars();
            StringEquality();
            StringEqualityCompareRules();
            StringsAreImmutable();
            StringsAreImmutable2();
            FunWithStringBuilder();
            StringInterpolation();

            Console.ReadLine();
        }

        static void BasicStringFunctionality()
        {
            Console.WriteLine("=> Basic String Functionality:");
            string firstName = "Freddy";
            Console.WriteLine("Value of firstName: {0}", firstName);
            Console.WriteLine("firstName has {0} characters.", firstName.Length);
            Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());
            Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower());
            Console.WriteLine("firstName contains the letter y?: {0}", firstName.Contains("y"));
            Console.WriteLine("firstName after replace: {0}", firstName.Replace("dy", ""));
            Console.WriteLine();
        }

        static void StringConcatenation()
        {
            Console.WriteLine("=> String Concatenation:");
            string s1 = "Programming the ";
            string s2 = "PsychoDrill (PTP)";
            //  string s3 = s1 + s2;
            string s3 = String.Concat(s1, s2);
            Console.WriteLine(s3);
            Console.WriteLine();
        }

        static void EscapeChars()
        {
            Console.WriteLine("=> Escape characters:\a");
            string strWithTabs = "Model\tColor\tSpeed\tPet Name\a";
            Console.WriteLine(strWithTabs);

            Console.WriteLine("Everyone loves \"Hello World\"\a ");
            Console.WriteLine("C:\\MyApp\\bin\\Debug\a ");

            //  Adds a total of 4 blank lines (then beep again!).
            Console.WriteLine("All finished.\n\n\n\a");
            Console.WriteLine();

            //  The following string is printed verbatim,
            //  thus all escape characters are displayed.
            Console.WriteLine(@"C:\MyApp\bin\Debug");

            //  White space is preservedwith verbatim strings.
            string myLongString = @"This is a very
                very
                    very
                        long string";
            Console.WriteLine(myLongString);
            Console.WriteLine(@"Cerebus said""Darr! Pret-typeof sun-sets""");
            Console.WriteLine();
        }

        static void StringEquality()
        {
            Console.WriteLine("=> String equality:");
            string s1 = "Hello!";
            string s2 = "Yo!";
            Console.WriteLine("s1 = {0}", s1);
            Console.WriteLine("s2 = {0}", s2);
            Console.WriteLine();

            //  Test these string for equality.
            Console.WriteLine("s1 == s2: {0}", s1 == s2);
            Console.WriteLine("s1 == Hello!: {0}", s1 == "Hello!");
            Console.WriteLine("s1 == HELLO!: {0}", s1 == "HELLO!");
            Console.WriteLine("s1 == hello!: {0}", s1 == "hello!");
            Console.WriteLine("s1.Equals(s2): {0}", s1.Equals(s2));
            Console.WriteLine("Yo.Equals(s2): {0}", "Yo!".Equals(s2));
            Console.WriteLine();
        }

        static void StringEqualityCompareRules()
        {
            Console.WriteLine("=> String equality (Case Insensitive:)");
            string s1 = "Hello!";
            string s2 = "HELLO!";
            Console.WriteLine("s1 = {0}", s1);
            Console.WriteLine("s2 = {0}", s2);
            Console.WriteLine();

            //  Check the results of changing the default compare rules.
            Console.WriteLine("Default rules: s1 = {0}, s2 = {1}, s1.Equals(s2): {2}", s1, s2, s1.Equals(s2));
            Console.WriteLine("Ignore case: s1.Equals(s2, StringCmomparison.OrdinalIgnoreCase): {0}",
                s1.Equals(s2, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Ignore case, Invariant Culture: " +
                "s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase): {0}",
                s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase));
            Console.WriteLine();
            Console.WriteLine("Default rules: s1 = {0}, s2 = {1} s1.IndexOf(\"E\"): {2}",
                s1, s2, s1.IndexOf("E"));
            Console.WriteLine("Ignore case: s1.IndexOf(\"E\", StringComparison.OrdinalIgnoreCase): {0}",
                s1.IndexOf("E", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Ignore case, Invariant Culture: s1.IndexOf(\"E\", StringComparison.InvariantCultureIgnoreCase): {0}",
                s1.IndexOf("E", StringComparison.InvariantCultureIgnoreCase));
            Console.WriteLine();
        }

        static void StringsAreImmutable()
        {
            //  Set initial string value.
            string s1 = "This is my string";
            Console.WriteLine("s1 = {0}", s1);

            //  Uppercase s1?
            string upperString = s1.ToUpper();
            Console.WriteLine("upperString = {0}", upperString);

            //  Nope! s1 is in the same format!
            Console.WriteLine("s1 = {0}", s1);
        }

        static void StringsAreImmutable2()
        {
            string s2 = "My other string";
            s2 = "New string value";
        }

        static void FunWithStringBuilder()
        {
            Console.WriteLine("=> Using the StringBuilder:");
            StringBuilder sb = new StringBuilder("***** Fantastic Games *****");
            sb.Append("\n");
            sb.Append("Half Life");
            sb.Append("Morrowind");
            sb.Append("Deus Ex" + "2");
            sb.Append("System Shock");
            Console.WriteLine(sb.ToString());
            sb.Replace("2", "Invisible War");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("sb has {0} chars.", sb.Length);
            Console.WriteLine();
        }

        static void StringInterpolation()
        {
            //  Some local variables we will plug into our larger string
            int age = 4;
            string name = "Soren";

            //  Using curly bracket syntax.
            string greeting = string.Format("\tHello {0} your are {1} years old.", name.ToUpper(), age);

            //  Using string interpolation
            string greeting2 = $"\tHello{name.ToUpper()} you are {age} years old.";
        }
    }
}
