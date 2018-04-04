using System;

namespace CustomGenericMethods
{
    public static class MyGenericMethods
    {
        //  This method will swap any two items
        //  as specified by the type parameter<T>.
        public static void Swap<T>(ref T a, ref T b)
        {
            Console.WriteLine("You sent the Swap() method a {0}.", typeof(T));
            T temp = a;
            a = b;
            b = temp;
        }

        public static void DisplayBaseClass<T>()
        {
            //  BaseType is a method used in reflection,
            //  which will be examined in Chapter 15.
            Console.WriteLine("Base class of {0} is: {1}.", typeof(T), typeof(T).BaseType);
        }
    }
}
