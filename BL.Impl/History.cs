using System;
using System.Collections.Generic;
using BL.Abstr;
using BL.Impl.Exceptions;
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
            if (this.stack.Count > 0)
            {
                RobotCommand rc = this.stack.Pop();
                rc.Undo();
            }
            else
            {
                throw new NoHistoryException("There is no moves to undo");
            }
        }
        public int Count { get => this.stack.Count; }
    }
}
