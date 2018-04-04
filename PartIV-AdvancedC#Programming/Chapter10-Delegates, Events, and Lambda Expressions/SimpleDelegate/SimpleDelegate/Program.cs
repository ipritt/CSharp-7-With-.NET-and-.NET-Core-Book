using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDelegate
{
    //  This delegate can point to any methods,
    //  Taking two integers and returning an integer.
    public delegate int BinaryOp(int x, int y);

    public class SimpleMath
    {
        public int Add(int x, int y) => x + y;

        public  int Subtract(int x, int y) => x - y;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Simple Delegate Example *****\n");

            //  .NET delegates can also point to instance methods as well.
            SimpleMath m = new SimpleMath();

            //  Create a BinaryOp delegate object that
            // "points to" SimpleMath.Add().
            BinaryOp b = new BinaryOp(m.Add);


            DisplayDelegateInfo(b);
            Console.WriteLine();

            //  Invole Add() method indireclty using delegate object.
            Console.WriteLine("10 + 10 is {0}", b(10, 10));
            Console.WriteLine();
        }

        static void DisplayDelegateInfo(Delegate delObj)
        {
            //  Print the names of each member in the
            //  delegate's invocation list.
            foreach(Delegate d in delObj.GetInvocationList())
            {
                Console.WriteLine("Method Name: {0}", d.Method);
                Console.WriteLine("Type Name: {0}", d.Target);
            }
        }
    }
}
