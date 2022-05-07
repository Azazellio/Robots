using System;
using BL.Abstr;
using BL.Impl;
using BL.Impl.Commands;
using BL.Impl.Exceptions;

namespace RobotsConsole
{
    class Program
    {
        static App app;
        static IField field;
        static InputProcessor inputP;
        static Robot robot;
        static History history;
        static RobotCommand MoveUpC;
        static RobotCommand MoveLeftC;
        static RobotCommand MoveRightC;
        static RobotCommand MoveDownC;
        static FieldShower shower;

        static string exc = "An error occured";

        static void Main(string[] args)
        {
            app = new App();

            field = app.StartApp();
            inputP = new InputProcessor();
            robot = field.GetRobot();
            robot.SetBatteryCustom(1000000);
            history = new History();

            MoveUpC = new MoveUpCommand(field.GetRobot());
            MoveLeftC = new MoveLeftCommand(field.GetRobot());
            MoveRightC = new MoveRightCommand(field.GetRobot());
            MoveDownC = new MoveDownCommand(field.GetRobot());


            inputP.AddMap("w", MoveUpC);
            inputP.AddMap("a", MoveLeftC);
            inputP.AddMap("d", MoveRightC);
            inputP.AddMap("s", MoveDownC);
            Console.WriteLine("Your robot is " + robot.GetCompilerTimeType().ToString());

            shower = new FieldShower();

            Console.WriteLine("Press any button to start");
            Console.ReadLine();

            Run();
        }
        static void Run()
        {
            MoveUpC = new MoveUpCommand(field.GetRobot());
            MoveLeftC = new MoveLeftCommand(field.GetRobot());
            MoveRightC = new MoveRightCommand(field.GetRobot());
            MoveDownC = new MoveDownCommand(field.GetRobot());

            Console.WriteLine(shower.GetString(field));

            inputP.ClearDict();
            inputP.AddMap("w", MoveUpC);
            inputP.AddMap("a", MoveLeftC);
            inputP.AddMap("d", MoveRightC);
            inputP.AddMap("s", MoveDownC);

            string comm = Console.ReadLine();

            if (comm == "undo")
            {
                try
                {
                    history.Undo();
                    field = app.UpdateField(field);
                }
                catch (NoHistoryException e)
                {
                    Console.WriteLine(exc + e);
                    Console.ReadLine();
                }
            }
            else
            {
                try
                {
                    RobotCommand robotCommand = inputP.GetCommandByInput(comm);
                    IFieldSnapshot snapshot = robotCommand.AddBackup(field.CreateSnapshot());
                    RobotCommand command = inputP.ExecuteByInput(comm);

                    history.Push((RobotCommand)command.Clone());
                    field = app.UpdateField(field);
                }
                catch (RobotCommandException e)
                {
                    Console.WriteLine(exc + e);
                    Console.ReadLine();
                }
            }
            //Console.Clear();
            Run();

        }
    }
}

