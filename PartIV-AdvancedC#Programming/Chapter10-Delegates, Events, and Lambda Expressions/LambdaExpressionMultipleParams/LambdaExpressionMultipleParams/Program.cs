using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionMultipleParams
{
    class Program
    {
        public delegate string VerySimpleDelegate();

        static void Main(string[] args)
        {
            //  Register with delegate as a lambda expression.
            SimpleMath m = new SimpleMath();
            m.SetMathHandler((msg, result) =>
            {
                Console.WriteLine("Message: {0}, Result: {1}", msg, result);
            });

            //  This will execute the lambda expression.
            m.Add(10, 10);

            //  Prints "Enjoy your string!" to the console.
            VerySimpleDelegate d = new VerySimpleDelegate(() =>
            { return "Enjoy your string!"; });

            Console.WriteLine("Result from zero param delegate: {0}", d());
        }
    }
}
