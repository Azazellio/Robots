using System;
using System.Collections.Generic;
using BL.Abstr;
namespace BL.Impl
{
    public class History
    {
        private Stack<RobotCommand> stack;
        public History()
        {
            this.stack = new Stack<RobotCommand>();
        }
        public void Push(RobotCommand comm)
        {
            this.stack.Push(comm);
        }
        public void Undo()
        {
            RobotCommand rc = this.stack.Pop();
            rc.Undo();
        }
    }
}
