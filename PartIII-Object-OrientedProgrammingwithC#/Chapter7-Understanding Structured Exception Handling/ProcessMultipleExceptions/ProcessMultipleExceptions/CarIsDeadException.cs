using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMultipleExceptions
{
    [Serializable]
    class CarIsDeadException : ApplicationException
    {
        private string messageDetails = String.Empty;
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }

        public CarIsDeadException() { }
        public CarIsDeadException(string message)
            : base(message) { }
        public CarIsDeadException(string message, System.Exception inner)
            : base(message, inner) { }
        protected CarIsDeadException(System.Runtime.Serialization.SerializationInfo info,
                                     System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
        public CarIsDeadException(string message, string cause, DateTime time)
            : base(message)
        {
            //messageDetails = message;
            CauseOfError = cause;
            ErrorTimeStamp = time;
        }

        //  Override the Exception.Message property.
        public override string Message => $"Car Error Message: {messageDetails}";
    }
}
