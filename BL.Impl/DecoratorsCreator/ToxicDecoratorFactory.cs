using BL.Abstr;
using BL.Impl.RobotDecorators;

namespace BL.Impl.DecoratorsCreator
{
    class ToxicDecoratorFactory : RobotDecoratorAbstractFactory
    {
        public override AbstractRobotDecorator CreateDecorator(Robot robot)
        {
            var res = new ToxicRobotDecorator();
            res.SetRobot(robot);
            return res;
        }
    }
}
