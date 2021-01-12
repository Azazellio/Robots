using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace BL.Abstr
{
    public abstract class RobotCommand:ICloneable
    {
        public event EventHandler CanExecuteChanged;
        protected Robot robot;
        protected IFieldSnapshot backUp;
        public RobotCommand(Robot robot)
        {
            this.robot = robot;
        }
        public RobotCommand() { }
        public abstract void Execute();

        public IFieldSnapshot AddBackup(IFieldSnapshot snap)
        {
            this.backUp = snap;
            return snap;
        }
        public IFieldSnapshot Undo()
        {
            this.backUp.Restore();
            return this.backUp;
        }

        public abstract object Clone();
    }
}
