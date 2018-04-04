using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyShapes;
using Chapter14.My3DShapes;

//  Resolve name clash ambiguity using a custom alias.
using The3DHexagon = Chapter14.My3DShapes.Hexagon;

namespace CustomNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            The3DHexagon h = new The3DHexagon();
            //  Resolve name clash ambiguity using full qualified name.
            Chapter14.My3DShapes.Circle c = new Chapter14.My3DShapes.Circle();
            Chapter14.My3DShapes.Square s = new Chapter14.My3DShapes.Square();
        }
    }
}
