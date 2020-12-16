using BL.Abstr;

namespace BL.Impl.Commands
{
    public class MoveDownCommand : RobotCommand
    {
        public MoveDownCommand(Robot robot) : base(robot) { }
        public override void Execute()
        {
            robot.ActionMoveDown();
        }
    }
}
