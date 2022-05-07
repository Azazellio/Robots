using System;
using BL.Abstr;

namespace BL.Impl.Exceptions
{
    public class OutOfBoundException : RobotCommandException
    {
        public OutOfBoundException() : base() { }
        public OutOfBoundException(string message) : base(message) { }
        public OutOfBoundException(string message, Exception inner) : base(message, inner) { }
    }
}
