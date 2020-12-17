using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace BL.Abstr
{
    public abstract class RobotCommand
    {
        public event EventHandler CanExecuteChanged;

        protected Robot robot;
        protected IFieldSnapshot backUp;
        public RobotCommand(Robot robot)
        {
            this.robot = robot;
        }
        public abstract void Execute();

        public void AddBackup(IFieldSnapshot snap)
        {
            this.backUp = snap;
        }
        public void Undo()
        {
            this.backUp.Restore();
        }
    }
}
