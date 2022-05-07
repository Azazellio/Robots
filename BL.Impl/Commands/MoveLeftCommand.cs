using BL.Abstr;

namespace BL.Impl.Commands
{
    public class MoveLeftCommand : RobotCommand
    {
        public MoveLeftCommand(Robot robot) : base(robot) { }

        public override object Clone()
        {
            var res = new MoveLeftCommand((Robot)this.robot.Clone());
            res.backUp = this.backUp;
            return res;
        }
        public override void Execute()
        {
            this.robot.ActionMoveLeft();
        }
    }
}
