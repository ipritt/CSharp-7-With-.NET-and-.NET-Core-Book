using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringIndexer
{
    public class PersonCollection : IEnumerable
    {
        //  Add the indexer to the existing class definition.
        private Dictionary<string, Person> listPeople = new Dictionary<string, Person>();

        public void ClearPeople() { listPeople.Clear(); }

        public int Count => listPeople.Count;

        //  Foreach enumeration support.
        IEnumerator IEnumerable.GetEnumerator() => listPeople.GetEnumerator();

        //  Custom indexer for this class.
        public Person this[string name]
        {
            get => (Person)listPeople[name];
            set => listPeople[name] = value;
        }
    }
}
