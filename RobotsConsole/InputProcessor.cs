using BL.Abstr;
using System.Collections.Generic;

namespace RobotsConsole
{
    class InputProcessor
    {
        private Dictionary<string, RobotCommand> mapping;
        public InputProcessor()
        {
            this.mapping = new Dictionary<string, RobotCommand>();
        }
        public void AddMap(string input, RobotCommand command)
        {
            this.mapping.Add(input, command);
        }
        public void ExecuteByInput(string input)
        {
            this.mapping[input].Execute();
        }
        public void ClearDict()
        {
            this.mapping = new Dictionary<string, RobotCommand>();
        }
    }
}
