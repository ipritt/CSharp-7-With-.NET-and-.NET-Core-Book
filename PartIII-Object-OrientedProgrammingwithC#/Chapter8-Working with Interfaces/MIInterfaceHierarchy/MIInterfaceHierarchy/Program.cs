using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIInterfaceHierarchy
{
    //  Mulitple inheritance for interface types is a-okay.
    interface IDrawable { void Draw(); }
    interface IPrintable { void Print(); void Draw(); }// <--Note possible name clash here!
    //  Multiple interface inheritance. OK!
    interface IShape : IDrawable, IPrintable { int GetNumberOfSides(); }

    class Rectangle : IShape
    {
        public int GetNumberOfSides() { return 4; }
        public void Draw() { Console.WriteLine("Drawing..."); }
        public void Print() { Console.WriteLine("Printing..."); }
    }

    class Square : IShape
    {
        //  Using explicit implementation to handle member name clash.
        void IPrintable.Draw() { Console.WriteLine("Drawing to printer..."); }
        void IDrawable.Draw() { Console.WriteLine("Drawing to screen..."); }
        public void Print() { Console.WriteLine("Printing..."); }
        public int GetNumberOfSides() { return 4; }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
