using BL.Abstr;
using BL.Impl.RobotDecorators;

namespace BL.Impl.DecoratorsCreator
{
    class ToxicDecoratorFactory : RobotAbstractFactory
    {
        public override Robot CreateRobot()
        {
            return new ToxicRobotDecorator();
        }
    }
}
