using System;
using System.Runtime.Serialization;

namespace Lemon
{
    [Serializable]
    public class LemonException : Exception
    {
        public LemonException()
        {

        }

        public LemonException(SerializationInfo serializationInfo, StreamingContext context)
            : base(serializationInfo, context)
        {

        }

        public LemonException(string message)
            : base(message)
        {

        }

        public LemonException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
