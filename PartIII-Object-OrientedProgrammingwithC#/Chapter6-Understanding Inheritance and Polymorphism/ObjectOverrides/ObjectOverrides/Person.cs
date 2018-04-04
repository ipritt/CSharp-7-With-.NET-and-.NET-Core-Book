using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrides
{
    //  Remember! Person extends Object.
    class Person
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public int Age { get; set; }
        public string SSN { get; set; } = "";

        public Person(){ }
        public Person(string fName, string lName, int personAge)
        {
            FirstName = fName;
            LastName = lName;
            Age = personAge;
        }

        public override string ToString() =>
            $"[First Name: {FirstName}; Last Name: {LastName}; Age: {Age}]";

        //public override bool Equals(object obj)
        //{
        //    if(obj is Person && obj != null)
        //    {
        //        Person temp;
        //        temp = (Person)obj;
        //        if(temp.FirstName == this.FirstName
        //           && temp.LastName == this.LastName
        //           && temp.Age == this.Age)
        //        { return true; }
        //        else
        //        { return false; }
        //    }
        //    return false;
        //}
        //  Or use ToString() comparison
        public override bool Equals(object obj) => obj?.ToString() == ToString();

        //  Return a hash code based on a point of unique string data.
        public override int GetHashCode() => SSN.GetHashCode();
    }
}
