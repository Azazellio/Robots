using System;
using BL.Abstr;

namespace BL.Impl.Exceptions
{
    public class FullBackpackException : RobotCommandException
    {
        public FullBackpackException() : base() { }
        public FullBackpackException(string message) : base(message) { }
        public FullBackpackException(string message, Exception inner) : base(message, inner) { }
    }
}
