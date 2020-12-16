using BL.Abstr;
using BL.Impl.RobotDecorators;

namespace BL.Impl.DecoratorsCreator
{
    class ProtectedDecoratorFactory : RobotDecoratorAbstractFactory
    {
        public override AbstractRobotDecorator CreateDecorator(Robot robot)
        {
            var res =  new ProtectedRobotDecorator();
            res.SetRobot(robot);
            return res;
        }
    }
}
