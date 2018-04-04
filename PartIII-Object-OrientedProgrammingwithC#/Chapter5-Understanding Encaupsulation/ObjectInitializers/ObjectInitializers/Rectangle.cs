using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializers
{
    class Rectangle
    {
        private Point topLeft = new Point();
        private Point bottomRight = new Point();

        public Point TopLeft { get; set; }
        public Point BottomRight { get; set; }

        public void DisplayStats()
        {
            Console.WriteLine("TopLeft: {0}, {1}, {2} BottomRight: {3}, {4}, {5}",
                               topLeft.X, topLeft.Y, topLeft.Color, bottomRight.X, 
                               bottomRight.Y, bottomRight.Color);
        }
    }
}
