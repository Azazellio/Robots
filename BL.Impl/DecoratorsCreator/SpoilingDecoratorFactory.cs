using BL.Abstr;
using BL.Impl.RobotDecorators;

namespace BL.Impl.DecoratorsCreator
{
    class SpoilingDecoratorFactory : RobotAbstractFactory
    {
        public override Robot CreateRobot()
        {
            return new SpoilingRobotDecorator();
        }
    }
}
