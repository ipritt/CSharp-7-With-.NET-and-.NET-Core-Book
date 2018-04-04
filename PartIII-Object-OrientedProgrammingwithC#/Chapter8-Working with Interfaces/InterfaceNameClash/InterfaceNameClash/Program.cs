using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceNameClash
{
    //  Draw image to a form.
    public interface IDrawToForm { void Draw(); }

    //  Draw to buffer in memory.
    public interface IDrawToMemory { void Draw(); }

    //  Render to the printer.
    public interface IDrawToPrinter { void Draw(); }

    class Octagon : IDrawToForm, IDrawToMemory, IDrawToPrinter
    {
        //public void Draw()
        //{
        //    Console.WriteLine("Drawing the Octagon...");
        //}

        //  Explicitly bind Draw() implementations
        //  to a given interface.
        void IDrawToForm.Draw() => Console.WriteLine("Drawing to form...");
        void IDrawToMemory.Draw() => Console.WriteLine("Drawing to memory...");
        void IDrawToPrinter.Draw() => Console.WriteLine("Drawing to printer...");
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Interface Name Clashes *****\n");

            //  All of these invocations call the
            //  same Draw() method.
            Octagon oct = new Octagon();
            
            IDrawToForm itfForm = (IDrawToForm)oct;
            itfForm.Draw();
            //  Shorthand notation if you don't need
            //  the interface variable for later use.
            ((IDrawToForm)oct).Draw();

            //  Could also use the "is" keyword.
            if (oct is IDrawToForm dtm)
                dtm.Draw();

            IDrawToPrinter itfPrinter = (IDrawToPrinter)oct;
            itfPrinter.Draw();

            IDrawToMemory itfMemory = (IDrawToMemory)oct;
            itfMemory.Draw();
        }
    }
}
