using BL.Abstr;

namespace BL.Impl
{
    class FieldSnapshot : IFieldSnapshot
    {
        private IGameObject[,] fieldarr;
        private Robot robot;
        private IField field;

        public FieldSnapshot(IGameObject [,] fieldarr, Robot robot, IField field)
        {
            this.fieldarr = fieldarr;
            this.robot = robot;
            this.field = field;
        }

        public void Restore()
        {
            this.field.SetFieldArr(this.fieldarr);
            this.field.SetRobot(this.robot);
        }
    }
}
