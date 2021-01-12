using BL.Abstr;

namespace BL.Impl.Commands
{
    public class MoveUpCommand : RobotCommand
    {
        public MoveUpCommand(Robot robot) : base(robot) { }

        public override object Clone()
        {
            var res = new MoveUpCommand((Robot)this.robot.Clone());
            res.backUp = this.backUp;
            return res;
        }

        public override void Execute()
        {
            robot.ActionMoveUp();
        }
    }
}
