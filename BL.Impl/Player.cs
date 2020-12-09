using System;
using BL.Abstr;

namespace BL.Impl
{
    public class Player
    {
        public Guid PlayerId;
        public string Name;
        private IRobotProducer RobotProducer;
        public Player(string name)
        {
            this.PlayerId = Guid.NewGuid();
            this.Name = name;
            this.RobotProducer =  new RobotProducer();
        }
        public Robot GetRobot()
        {
            var robot = this.RobotProducer.PickRobot(this.PlayerId);
            return robot;
        }
    }
}
