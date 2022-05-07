using System;

namespace BL.Impl.Exceptions
{
    public class NoHistoryException : Exception
    {
        public NoHistoryException() : base() { }
        public NoHistoryException(string message) : base(message) { }
        public NoHistoryException(string message, Exception inner) : base(message, inner) { }
    }
}
