using BL.Abstr;
using BL.Impl.RobotDecorators;

namespace BL.Impl.DecoratorsCreator
{
    class SpoilingDecoratorFactory : RobotDecoratorAbstractFactory
    {
        public override AbstractRobotDecorator CreateDecorator(Robot robot)
        {
            var res = new SpoilingRobotDecorator();
            res.SetRobot(robot);
            return res;
        }
    }
}
