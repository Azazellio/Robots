using System;
using BL.Abstr;

namespace BL.Impl.Exceptions
{
    public class EmptyBatteryException: RobotCommandException
    {
        public EmptyBatteryException() : base() { }
        public EmptyBatteryException(string message) : base(message) { }
        public EmptyBatteryException(string message, Exception inner) : base(message, inner) { }
    }
}
