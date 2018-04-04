using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    abstract partial class Employee
    {
        //  Field data.
        private string empName;
        private int empAge;
        private int empID;
        private float currPay;
        private string empSSN;

        //  Constructors.
        public Employee() { }
        public Employee(string name, int id, float pay)
            : this(name, 0, id, pay, "") { }
        public Employee(string name, int age, int id, float pay)
        {
            Name = name;
            Age = age;
            ID = id;
            Pay = pay;        }
        public Employee(string name, int age, int id, float pay, string ssn)
            : this(name, age, id, pay)
        {
            empSSN = ssn;
        }
    }
}
