using BL.Abstr;

namespace BL.Impl.Commands
{
    public class MoveUpCommand : RobotCommand
    {
        public MoveUpCommand(IField field) : base(field) { }
        public override void Execute()
        {
            field.GetRobot().ActionMoveUp();
        }
    }
}
