using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringIndexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Indexers *****\n");

            PersonCollection myPeople = new PersonCollection()
            {
                ["Homer"] = new Person("Homer", "Simpson", 40),
                ["Marge"] = new Person("Marge", "Simpson", 38)
            };

            //  Get "Homer" and print data.
            Person homer = myPeople["Homer"];
            Console.WriteLine(homer.ToString());
        }
    }
}
