using BL.Abstr;

namespace BL.Impl.Commands
{
    public class MoveRightCommand : RobotCommand
    {
        public MoveRightCommand(Robot robot) : base(robot) { }
        public override void Execute()
        {
            robot.ActionMoveRight();
        }
    }
}
