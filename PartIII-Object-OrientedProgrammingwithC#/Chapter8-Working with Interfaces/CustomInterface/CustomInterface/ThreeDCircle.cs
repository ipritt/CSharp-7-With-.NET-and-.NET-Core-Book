using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    //  This class extends Circle and hides the inherited
    //  Draw() method using 'new' keyword.
    class ThreeDCircle : Circle, IDraw3D
    {
        //  Hide the PetName propery above me.
        public override string PetName { get; set; }

        //  Hide any Draw() implementation above me.
        public override void Draw()
        {
            Console.WriteLine("Drawing a 3D Circle");
        }

        //  IDraw3D implementation.
        public void Draw3D() => Console.WriteLine("Drawing Circle in 3D!");
    }
}
