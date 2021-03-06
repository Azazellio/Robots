﻿using BL.Abstr;
using System.Collections.Generic;

namespace RobotsConsole
{
    class InputProcessor
    {
        private Dictionary<string, RobotCommand> mapping;
        private IField field;
        public InputProcessor()
        {
            this.mapping = new Dictionary<string, RobotCommand>();
            //this.field = field;
        }
        public void AddMap(string input, RobotCommand command)
        {
            this.mapping.Add(input, command);
        }
        public RobotCommand ExecuteByInput(string input)
        {
            this.mapping[input].Execute();
            return this.mapping[input];
        }
        public RobotCommand GetCommandByInput(string input)
        {
            return this.mapping[input];
        }
        public void ClearDict()
        {
            this.mapping = new Dictionary<string, RobotCommand>();
        }
    }
}
