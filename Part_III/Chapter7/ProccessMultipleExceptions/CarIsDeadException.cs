



using System;
using System.Runtime.Serialization;

namespace ProccessMultipleExceptions
{
    [Serializable]
    public class CarIsDeadException : ApplicationException
    {
        //private string _messageDetails = String.Empty;

        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }

        public CarIsDeadException(string cause, DateTime time) :
            this(cause, time, string.Empty) { }
        
        public CarIsDeadException(string cause, DateTime time, string message) :
            this(cause, time, string.Empty, null) { }
        public CarIsDeadException(string cause, DateTime time, string message, System.Exception inner) :
            base(message, inner)
        {
            //_messageDetails = message;
            CauseOfError = cause;
            ErrorTimeStamp = time;
        }

        protected CarIsDeadException(string cause, DateTime time, SerializationInfo info, StreamingContext context) :
            base(info, context)
        {
            CauseOfError = cause;
            ErrorTimeStamp = time;
        }

        // public override string Message
        //     => $"Mensagem do erro: {_messageDetails}";
    }
}
