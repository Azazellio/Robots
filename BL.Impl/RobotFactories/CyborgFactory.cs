using BL.Abstr;
using System;
using BL.Impl.Robots;

namespace BL.Impl.RobotFactories
{
    class CyborgFactory : RobotAbstractFactory
    {
        public CyborgFactory() { }
        public override Robot CreateRobot()
        {
            Robot robot = new Cyborg();
            return robot;
        }
    }
}
