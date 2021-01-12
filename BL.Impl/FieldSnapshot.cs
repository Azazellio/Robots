using BL.Abstr;

namespace BL.Impl
{
    public class FieldSnapshot : IFieldSnapshot
    {
        protected IGameObject[,] fieldarr;
        protected Robot robot;
        protected IField field;
        protected FieldSnapshot() { }
        public FieldSnapshot(IGameObject [,] fieldarr, Robot robot, IField field)
        {
            this.fieldarr = fieldarr;
            
            this.robot = robot;

            foreach(IGameObject gameObject in fieldarr)
            {
                if(gameObject != null)
                {
                    if(gameObject.GetCompilerTimeType() == robot.GetCompilerTimeType())
                    {
                        fieldarr[gameObject.GetPosY, gameObject.GetPosX] = null;
                        break;
                    }
                }
            }
            fieldarr[robot.GetPosY, robot.GetPosX] = robot;
            this.field = field;
        }
        public void Restore()
        {
            this.field.SetFieldArr(this.fieldarr);
            this.field.SetRobot(this.robot);
        }
    }
}
