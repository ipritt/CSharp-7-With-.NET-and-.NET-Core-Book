using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalizableDisposableClass
{
    //  A sophisticated resource wrapper.
    public class MyResourceWrapper : IDisposable
    {
        //  Used to determine if Dispose() has already been called.
        private bool disposed = false;
        //  The object user will call this method to clean up resources ASAP.
        public void Dispose()
        {
            //  Call our helper method.
            //  Specifying "true" signifies that the object user triggered the cleanup.
            CleanUp(true);

            //  No need to finalize if user called Dispose(),
            //  so suppress finalization.
            GC.SuppressFinalize(this);
        }

        private void CleanUp(bool disposing)
        {
            //  Be sure we have no already been disposed!
            if(!this.disposed)
            {
                //  If disposing equals true, dispose all managed resources.
                if(disposing)
                {
                    //  Dispose managed resources.
                }
                //  Clean up unmanaged resources here.
                //  Call Dispose() on other contained disposable objects.
            }
            disposed = true;
        }

        //  The garbage collector will call this method if
        //  the object user forgets to call Dispose().
        ~MyResourceWrapper()
        {
            Console.Beep();
            //  Call our helper method.
            //  Specifying "false" signifies that the GC triggered the cleanup.
            CleanUp(false);
        }
    }
}
