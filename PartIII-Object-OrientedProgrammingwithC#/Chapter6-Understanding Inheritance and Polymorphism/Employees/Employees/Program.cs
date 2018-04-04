using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Program
    {
        //  Create a subclass object and access base class functionality.
        static void Main(string[] args)
        {
            Console.WriteLine("***** The Employee Class Hierachy *****\n");
            SalesPerson fred = new SalesPerson();
            fred.Age = 31;
            fred.Name = "Fred";
            fred.SalesNumber = 50;

            //Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-23-2322", 9000);
            //chucky.GiveBonus(300);
            //double cost = chucky.GetBenefitCost();
            //chucky.DisplayStats();
            //Console.WriteLine();

            //SalesPerson fran = new SalesPerson("Fran", 43, 93, 3000, "932-32-3232", 31);
            //fran.GiveBonus(200);
            //fran.DisplayStats();
            //Console.WriteLine();

            //  Define my benefit level.
            Employee.BenefitPackage.BenefitPackageLevel myBenefitLevel = Employee.BenefitPackage.BenefitPackageLevel.Platinum;
            Console.WriteLine("My Benefit Level is {0}", myBenefitLevel);
            Console.WriteLine();

            //  A better bonus system!
            Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-23-2322", 9000);
            chucky.GiveBonus(300);
            chucky.DisplayStats();
            Console.WriteLine();

            SalesPerson fran = new SalesPerson("Fran", 43, 93, 3000, "932-32-3232", 31);
            fran.GiveBonus(200);
            fran.DisplayStats();
            Console.WriteLine();
        }

        static void CastingExamples()
        {
            //  A Manager "is-a" System.Object, so we can store a
            //  Manager reference in an object variable just fine.
            object frank = new Manager("Frank Zappa", 9, 3000, 40000, "111-11-1111", 5);
            //  Error! Cannot pass 'System.Object' to 'Employee' 
            //GivePromotion(frank);
            //  OK!
            GivePromotion((Manager)frank);

            //  A Manager "is-an" Employee too.
            Employee moonUnit = new Manager("MoonUnit Zappa", 2, 3001, 20000, "101-11-1321", 1);
            GivePromotion(moonUnit);

            //  A PTSalesPerson "is-a" SalesPerson.
            SalesPerson jill = new PTSalesPerson("Jill", 834, 3002, 100000, "111-12-1119", 90);
            GivePromotion(jill);

            //  Ack! You can't cast frank to a Hexagon, but this
            //  compiles fine!
            //  Would recieve runtime exception.
            frank = new Manager();
            //Hexagon hex = (Hexagon)frank;
            //  Catch a possible invalid cast.
            Hexagon hex;
            try
            {
                hex = (Hexagon)frank;
            }
            catch(InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //  Use "as" to test compatibilty.
            //  "as" returns a null reference.
            object[] things = new object[4];
            things[0] = new Hexagon();
            things[1] = false;
            things[2] = new Manager();
            things[3] = "Last thing";

            foreach(object item in things)
            {
                Hexagon h = item as Hexagon;
                if(h == null)
                    Console.WriteLine("Item is not a hexagon");
                else
                {
                    h.Draw();
                }
            }

            //  Discards with the "is" keyword
            //  use as catchall in if or switch statement
            if(frank is var _)
            {
                //  do something
            }
        }

        static void GivePromotion(Employee emp)
        {
            //  Increase pay...
            //  Gice new parking space in company garage...
            Console.WriteLine("{0} was promoted!", emp.Name);
            //  "is" returns false if incompatible
            //if(emp is SalesPerson)
            // In C# 7 the "is" keyword can assign converted type to a variable to prevent double cast.
            //if(emp is SalesPerson s)
            //{
            //    //  Perform explicit cast from Employee to SalesPerson to gain access to SalesNumber
            //    //Console.WriteLine("{0} made {1} sale(s)!", emp.Name, ((SalesPerson)emp).SalesNumber);
            //    //  C# 7 "is" prevents need for this cast.
            //    Console.WriteLine("{0} made {1} sale(s)!", emp.Name, s.SalesNumber);
            //    Console.WriteLine();
            //}
            ////if(emp is Manager)
            //// In C# 7 the "is" keyword can assign converted type to a variable to prevent double cast.
            //if (emp is Manager m)
            //{
            //    //  Perform explicit cast from Employee to Manager to gain access to StockOptions
            //    //Console.WriteLine("{0} had {1} stock options...", emp.Name, ((Manager)emp).StockOptions);
            //    //  C# 7 "is" prevents need for this cast.
            //    Console.WriteLine("{0} had {1} stock options...", emp.Name, m.StockOptions);
            //    Console.WriteLine();
            //}
            //  Using Pattern Matching with switch statement.
            //  can use "when" and discards
            switch (emp)
            {
                case SalesPerson s when s.SalesNumber > 5:
                    Console.WriteLine("{0} made {1} sale(s)!", emp.Name, s.SalesNumber);
                    break;
                case Manager m:
                    Console.WriteLine("{0} had {1} stock options...", emp.Name, m.StockOptions);
                    break;
                //case Intern _:
                    //Ignore interns
                    //break;
                case null:
                    //  Do something when null
                    break;
            }
            Console.WriteLine();
        }
    }
}
