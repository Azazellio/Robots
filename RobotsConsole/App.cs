using BL.Abstr;
using BL.Impl;

namespace RobotsConsole
{
    class App
    {
        public IField StartApp()
        {
            Player p = new Player("azazalo");
            IRobotProducer rp = new RobotProducer();
            Robot MyRobot = rp.PickRobot(p.PlayerId);
            IFieldBuilder builder = new FieldBuilder();
            var field = builder.CreateField(10, 10, MyRobot);
            return field;
        }
    }
}
