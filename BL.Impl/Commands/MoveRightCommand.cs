﻿using BL.Abstr;

namespace BL.Impl.Commands
{
    public class MoveRightCommand : RobotCommand
    {
        public MoveRightCommand(Robot robot) : base(robot) { }

        public override object Clone()
        {
            var res = new MoveRightCommand((Robot)this.robot.Clone());
            res.backUp = this.backUp;
            return res;
        }

        public override void Execute()
        {
            robot.ActionMoveRight();
        }
    }
}
