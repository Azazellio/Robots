using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace BL.Abstr
{
    public abstract class RobotCommand
    {
        public event EventHandler CanExecuteChanged;

        protected IField field;
        protected string backUp;
        public RobotCommand(IField field)
        {
            this.field = field;
        }
        public abstract void Execute();
    }
}
