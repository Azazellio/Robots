

using System;

namespace BL.Abstr
{
    public abstract class AbstractRobotDecorator : Robot
    {
        protected Robot robot;
        public AbstractRobotDecorator() : base() { }
        public void SetRobot(Robot robot)
        {
            this.robot = robot;
            this.PlayerId = robot.PlayerId;
        }
    }
}
