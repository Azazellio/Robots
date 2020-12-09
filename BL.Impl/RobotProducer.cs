using System;
using BL.Abstr;
using BL.Impl.Robots;
using BL.Impl.RobotFactories;

namespace BL.Impl
{
    public class RobotProducer:IRobotProducer
    {

        public RobotProducer() { }
        private RobotAbstractFactory factory;
        public Robot PickRobot(Guid playerId)
        {
            CreateCorrectFactory();
            Robot robot = this.factory.CreateRobot();
            robot.SetPlayerId(playerId);
            return robot;
        }
        private void CreateCorrectFactory()
        {
            Type type = getCase();
            if (type == typeof(Cyborg))
            {
                this.factory = new CyborgFactory();
            }
            else if(type == typeof(Worker))
            {
                this.factory = new WorkerFactory();
            }
            else if(type == typeof(BrightMind))
            {
                this.factory = new BrightMindFactory();
            }
        }
        private Type getCase()
        {
            Type type = null;
            Random rand = new Random();
            int decision = rand.Next(0, 100);
            if (decision < 20)
            {
                type = typeof(BrightMind);
            }
            else if(decision < 50)
            {
                type = typeof(Cyborg);
            }
            else if(decision < 100)
            {
                type = typeof(Worker);
            }
            return type;
        }
    }
}
