using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstData
{
    class MyMathClass
    {
        //public const double PI = 3.14;
        //  For attempt to set with constructor
        //public const double PI;

        //  Try to set PI in ctor?
        //public MyMathClass()
        //{
        //    //  Not possible-must assign at time of declaration.
        //    PI = 3.14;
        //}

        //  Read-only fields can be assigned in constructors
        //  but nowhere else.
        //  Good if you don't know value until runtime.
        //public readonly double PI;
        //public MyMathClass() => PI = 3.14;

        //  Read-only fields are not implicitly static, to expose
        //  at class level, must add static keyword.
        //  If value is known at compile time looks like const
        //  best to just use const.
        //public static readonly double PI = 3.14; 
        //  If not known until runtime, static read-only
        //  must use static constructor.
        public static readonly double PI;
        static MyMathClass() => PI = 3.14;

        //  Any attempt to make assignments to read-only
        //  field outside scope of a constructor is compile time error!
        //  Error!
        //public void ChangePI() => PI = 3.14444;

        static void LocalConstStringVariable()
        {
            //  A local constant data point can be directly accessed.
            const string fixedStr = "Fixed string Data";
            Console.WriteLine(fixedStr);

            //  Error!
            //fixedStr = "This will not work!";
        }
    }
}
