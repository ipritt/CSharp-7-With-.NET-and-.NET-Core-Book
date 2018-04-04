using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleIndexer
{
    //  Indexers allow you to access items in an array-like fashion.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** fun with Indexers *****\n");

            PersonCollection myPeople = new PersonCollection
            {
                //  Add objects with indexer syntax.
                [0] = new Person("Homer", "Simpson", 40),
                [1] = new Person("Marge", "Simpson", 38),
                [2] = new Person("Lisa", "Simpson", 9),
                [3] = new Person("Bart", "Simpson", 7),
                [4] = new Person("Maggie", "Simpson", 2)
            };

            //  Now obtain and display each item using indexer.
            for (int i = 0; i < myPeople.Count; i++)
            {
                Console.WriteLine("Person number: {0}", i);
                Console.WriteLine("Name: {0} {1}", myPeople[i].FirstName, myPeople[i].LastName);
                Console.WriteLine("Age: {0}", myPeople[i].Age);
            }
            Console.WriteLine();
            UseGenereicListOfPeople();
        }

        static void UseGenereicListOfPeople()
        {
            List<Person> myPeople = new List<Person>
            {
                new Person("Lisa", "Simpson", 9),
                new Person("Bart", "Simpson", 7)
            };

            //  Change first person with indexer.
            myPeople[0] = new Person("Maggie", "Simpson", 2);

            //  Now obtain and display each item using indexer.
            for(int i = 0; i < myPeople.Count; i++)
            {
                Console.WriteLine("Person number: {0}", i);
                Console.WriteLine("Name: {0} {1}", myPeople[i].FirstName, myPeople[i].LastName);
                Console.WriteLine("Age: {0}", myPeople[i].Age);
            }
        }
    }
}
