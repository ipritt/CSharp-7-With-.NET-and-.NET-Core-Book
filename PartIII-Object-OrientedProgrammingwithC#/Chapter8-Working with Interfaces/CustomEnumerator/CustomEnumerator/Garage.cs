using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumerator
{
    //  Garage contains a set of Car objects.
    class Garage : IEnumerable
    {
        //  System.Array already implements IEnumerator!
        private Car[] carArray = new Car[4];
        
        //  Fill with some Car objects upon startup.
        public Garage()
        {
            carArray[0] = new Car("Rusty", 30);
            carArray[1] = new Car("Clucker", 55);
            carArray[2] = new Car("Zippy", 30);
            carArray[3] = new Car("Fred", 30);
        }

        public IEnumerator GetEnumerator()
        {
            //  Return the array object's IEnumerator.
            return carArray.GetEnumerator();
        }

        //  To hide functionality of IEnumerable from object level,
        //  make use of explicit interface implemenation.
        IEnumerator IEnumerable.GetEnumerator()
        {
            //  Return the array object's IEnumerator.
            return carArray.GetEnumerator();
        }
    }
}
