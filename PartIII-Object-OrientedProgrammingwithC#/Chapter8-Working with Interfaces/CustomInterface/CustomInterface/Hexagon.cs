using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    //  Hexagon does override Draw().
    class Hexagon : Shape, IPointy, IDraw3D
    {
        public Hexagon(){ }
        public Hexagon(string name) : base(name) { }

        public override void Draw() => Console.WriteLine("Drawing {0} the Hexagon", PetName);

        //  IPointy implementation.
        public byte Points { get { return 6; } }

        //  IDraw3d implementation.
        public void Draw3D() => Console.WriteLine("Drawing Hexagon in 3D!");
    }
}
