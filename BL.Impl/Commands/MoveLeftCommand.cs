using BL.Abstr;

namespace BL.Impl.Commands
{
    public class MoveLeftCommand : RobotCommand
    {
        public MoveLeftCommand(Robot robot) : base(robot) { }

        public override void Execute()
        {
            this.robot.ActionMoveLeft();
        }
    }
}
