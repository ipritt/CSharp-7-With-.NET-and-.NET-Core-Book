using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    //  The abstract base class of the hierarchy.
    abstract class Shape
    {
        public Shape(string name = "NoName")
        {
            PetName = name;
        }
        public string PetName { get; set; }

        //  A single virtual method.
        //  Changed to abstract.
        //  Force all child classes to define how to be rendered.
        //  Abstract methods can only be defined in abstract classes.
        public abstract void Draw();
    }
}
