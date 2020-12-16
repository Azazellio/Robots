using System;
using BL.Abstr;
using BL.Impl;
using BL.Impl.Commands;

namespace RobotsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            App app = new App();

            IField field = app.StartApp();
            var inputP = new InputProcessor();
            Robot robot = field.GetRobot();
            robot.SetBatteryCustom(1000000);

            RobotCommand MoveUpC = new MoveUpCommand(field.GetRobot());
            RobotCommand MoveLeftC = new MoveLeftCommand(field.GetRobot());
            RobotCommand MoveRightC = new MoveRightCommand(field.GetRobot());
            RobotCommand MoveDownC = new MoveDownCommand(field.GetRobot());

            inputP.AddMap("w", MoveUpC);
            inputP.AddMap("a", MoveLeftC);
            inputP.AddMap("d", MoveRightC);
            inputP.AddMap("s", MoveDownC);
            Console.WriteLine("Your robot is " + robot.GetCompilerTimeType().ToString());

            var shower = new FieldShower();

            Console.WriteLine("Press any button to start");
            Console.ReadLine();

            while (true)
            {
                MoveUpC = new MoveUpCommand(field.GetRobot());
                MoveLeftC = new MoveLeftCommand(field.GetRobot());
                MoveRightC = new MoveRightCommand(field.GetRobot());
                MoveDownC = new MoveDownCommand(field.GetRobot());

                inputP.ClearDict();
                inputP.AddMap("w", MoveUpC);
                inputP.AddMap("a", MoveLeftC);
                inputP.AddMap("d", MoveRightC);
                inputP.AddMap("s", MoveDownC);
                //Console.Clear();
                Console.WriteLine(shower.GetString(field));
                Console.WriteLine(app.builder.GetRobotRef());

                string comm = Console.ReadLine();
                //Console.Clear();
                inputP.ExecuteByInput(comm);
                field = app.UpdateField(field);
            }
        }
    }
}
