using System;
using System.Runtime.Serialization;

namespace Domain.Aggregates.Post
{
    public class InvalidTitleException : ArgumentException
    {

        protected InvalidTitleException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public InvalidTitleException(string message) : base(message)
        {
        }

        public InvalidTitleException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public InvalidTitleException(string message, string paramName) : base(message, paramName)
        {
        }

        public InvalidTitleException(string message, string paramName, Exception innerException) : base(message, paramName, innerException)
        {
        }
    }
}