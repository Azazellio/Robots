using BL.Abstr;
using System;
using BL.Impl.Robots;

namespace BL.Impl.RobotFactories
{
    class WorkerFactory : RobotAbstractFactory
    {
        public WorkerFactory() { }
        public override Robot CreateRobot()
        {
            Robot robot =  new Worker();
            return robot;
        }
    }
}
