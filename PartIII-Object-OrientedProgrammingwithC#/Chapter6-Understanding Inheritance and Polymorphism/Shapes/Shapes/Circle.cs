using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    //  Cicle DOES NOT override Draw().
    //  Changed Draw to abstract in Shape.
    //  If we did not implement the abstract Draw() method,
    //  Circle would also be considered abstract, and would
    //  have to be marked abstract!
    class Circle : Shape
    {
        public Circle(){ }
        public Circle(string name) : base(name){ }

        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Circle", PetName);
        }
    }
}
