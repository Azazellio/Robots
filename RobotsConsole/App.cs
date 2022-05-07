using BL.Abstr;
using BL.Impl;

namespace RobotsConsole
{
    class App
    {
        public IFieldBuilder builder;
        public IField StartApp()
        {
            Player p = new Player("azazalo");
            IRobotProducer rp = new RobotProducer();
            Robot MyRobot = rp.PickRobot(p.PlayerId);
            IFieldBuilder b = new FieldBuilder();
            this.builder = b;
            var field = builder.CreateField(10, 10, MyRobot);
            return field;
        }
        public IField UpdateField(IField field)
        {
            return this.builder.UpdateField(field);
        }
    }
}
