using BL.Abstr;

namespace BL.Impl.Commands
{
    public class MoveDownCommand : RobotCommand
    {
        public MoveDownCommand(Robot robot) : base(robot) { }

        public override object Clone()
        {
            var res = new MoveDownCommand((Robot)this.robot.Clone());
            res.backUp = this.backUp;
            return res;
        }

        public override void Execute()
        {
            robot.ActionMoveDown();
        }
    }
}
