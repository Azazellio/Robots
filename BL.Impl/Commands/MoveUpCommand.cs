using BL.Abstr;

namespace BL.Impl.Commands
{
    public class MoveUpCommand : RobotCommand
    {
        public MoveUpCommand(Robot robot) : base(robot) { }
        public override void Execute()
        {
            robot.ActionMoveUp();
        }
    }
}
