﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumeratorWithYield
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

        //  Iterator method.
        public IEnumerator GetEnumerator()
        {
            //  Return the array object's IEnumerator.
            //return carArray.GetEnumerator();

            ////  This will not get thrown until MoveNext() is called.
            //throw new Exception("This won't get called");

            //  This will get thrown immediately
            //throw new Exception("This will get called");
            return actualImplementation();
            IEnumerator actualImplementation()
            {
                foreach (Car c in carArray) { yield return c; }
            }
        }

        //  To hide functionality of IEnumerable from object level,
        //  make use of explicit interface implemenation.
        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    //  Return the array object's IEnumerator.
        //    return carArray.GetEnumerator();
        //}

        public IEnumerable GetTheCars(bool returnReversed)
        {
            //  do some error checking here
            return actualImplementation();

            IEnumerable actualImplementation()
            {
                //  Return the items in reverse.
                if(returnReversed)
                {
                    for (int i = carArray.Length; i != 0; i--)
                    {
                        yield return carArray[i - 1];
                    }
                }
                else
                {
                    //  Return the items as placed in the array.
                    foreach(Car c in carArray)
                    {
                        yield return c;
                    }
                }
            }
        }
    }
}
