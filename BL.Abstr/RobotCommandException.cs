using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Abstr
{
    public abstract class RobotCommandException : Exception
    {
        public RobotCommandException() : base() { }
        public RobotCommandException(string message) : base(message) { }
        public RobotCommandException(string message, Exception inner) : base(message, inner) { }
    }
}
