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
            RobotCommand MoveUpC = new MoveUpCommand(field);
            inputP.AddMap("u", MoveUpC);
            var Shower = new FieldShower();
            
            while (true)
            {
                field.ScanField();
                Console.WriteLine(Shower.GetString(field));
                string comm = Console.ReadLine();
                inputP.ExecuteByInput(comm);
            }

        }
    }
}
