using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Compiler errors!
            //  Value types cannot be set to null!
            //bool myBool = null;
            //int myInt = null;

            //  OK! Strings are reference types.
            //string myString = null;

            Console.WriteLine("***** Fun with Nullable Data *****\n");
            DatabaseReader dr = new DatabaseReader();

            //  Get int from "database".
            int? i = dr.GetInfoFromDatabase();
            if(i.HasValue)
                Console.WriteLine("Value of 'i' is: {0}", i.Value);
            else
                Console.WriteLine("Value of 'i' is undefined.");

            //  Get bool from "database".
            bool? b = dr.GetBoolFromDatabase();
            if(b != null)
                Console.WriteLine("Value of 'b' is: {0}", b.Value);
            else
                Console.WriteLine("Value of 'b' is undefined.");

            //  If the value from GetIntFromDatabase() is null,
            //  assign local variable to 100.
            int myData = dr.GetInfoFromDatabase() ?? 100;
            Console.WriteLine("Value of myData: {0}", myData);

            //  Long-hand notation not using ?? syntax.
            int? moreData = dr.GetInfoFromDatabase();
            if (!moreData.HasValue)
                moreData = 100;
            Console.WriteLine("Value of moreData: {0}", moreData);

            string[] str = { "Yep", "This is a string array!" };
            string[] str1 = { };
            TesterMethod(str);
            TesterMethod(str1);

            Console.ReadLine();
        }

        static void LocalNullableVariables()
        {
            //  Define some local nullable variables.
            int? nullableInt = 10;
            double? nullableDouble = 3.14;
            bool? nullableBool = null;
            char? nullableChar = 'a';
            int?[] arrayOfNullables = new int?[10];

            //  Error! Strings are reference types!
            //string? s = "oops";

            //  ? is shorthand notation for Nullanble<T>
            //  So, LocalNullableTypes could be implemented as:
            //static void LocalNullableVariables()
            //{
            //    //  Define some local nullable variables.
            //    Nullable<int> nullableInt = 10;
            //    Nullable<double> nullableDouble = 3.14;
            //    Nullable<bool> nullableBool = null;
            //    Nullable<char> nullableChar = 'a';
            //    Nullable<int>[] arrayOfNullables = new Nullable<int>?[10];
            //}
        }

        static void TesterMethod(string[] args)
        {
            //  We should check for null before accessing in the array data!
            if(args != null)
            {
                Console.WriteLine($"You sent me {args.Length} arguments.");
            }
            //  Or
            Console.WriteLine($"You sent me {args?.Length} arguments.");
            //  To leverage null coelescing operator...
            Console.WriteLine($"You sent me {args?.Length ?? 0} arguments.");
        }
    }

    class DatabaseReader
    {
        //  Nullable data field.
        public int? numericValue = null;
        public bool? boolValue = true;

        //  Note the nullable return type.
        public int? GetInfoFromDatabase()
        { return numericValue; }

        //  Note the nullable return type.
        public bool? GetBoolFromDatabase()
        { return boolValue; }
    }
}
