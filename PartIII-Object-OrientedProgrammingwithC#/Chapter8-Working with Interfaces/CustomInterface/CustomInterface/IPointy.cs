using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    //  This interface defines the behavior of "having points".
    interface IPointy
    {
        //  A read-write propert in an interface would look like:
        //retType PropName { get; set; }

        //  while a write-only property in an interface would be:
        //retType PropName { set; }

        byte Points { get; }

        //  Implicitly public and abstract.
        //byte GetNumberOfPoints();
    }
}
