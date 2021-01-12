using BL.Impl.RobotDecorators;
using BL.Abstr;

namespace BL.Tests.Try2.Moqs.DecoratorsMoqs
{
    public class ProtectedDecoratorMoq: ProtectedRobotDecorator
    {
        public ProtectedDecoratorMoq() { }

        public void SetHasBeenCalled(bool hasbeen)
        {
            this.hasBeenCalled = hasbeen;
        }

    }
}
