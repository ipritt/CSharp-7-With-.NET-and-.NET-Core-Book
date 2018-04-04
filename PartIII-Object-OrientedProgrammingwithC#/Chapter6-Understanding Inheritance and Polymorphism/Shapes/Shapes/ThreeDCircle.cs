using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    //  This class extends Circle and hides the inherited
    //  Draw() method using 'new' keyword.
    class ThreeDCircle : Circle
    {
        //  Hide the PetName propery above me.
        public new string PetName { get; set; }

        //  Hide any Draw() implementation above me.
        public new void Draw()
        {
            Console.WriteLine("Drawing a 3D Circle");
        }
    }
}
