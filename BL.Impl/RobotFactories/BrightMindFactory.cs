using BL.Abstr;
using System;
using BL.Impl.Robots;

namespace BL.Impl.RobotFactories
{
    class BrightMindFactory : RobotAbstractFactory
    {
        public BrightMindFactory() { }
        public override Robot CreateRobot()
        {
            Robot robot = new BrightMind();
            return robot;
        }
    }
}
