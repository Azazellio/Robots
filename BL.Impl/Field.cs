using BL.Abstr;
using System.Collections.Generic;

namespace BL.Impl
{
    public class Field : IField
    {
        private IGameObject[,] fieldArr;
        private Robot robot;
        public Field() { }
        public Field(IGameObject[,] field, Robot robot)
        {
            this.fieldArr = field;
            this.robot = robot;
        }

        public Robot GetRobot()
        {
            return this.robot;
        }

        public int GetSizeY()
        {
            return this.fieldArr.GetLength(0);
        }

        public int GetSizeX()
        {
            return this.fieldArr.GetLength(1);
        }

        public IGameObject[,] GetField()
        {
            return this.fieldArr;
        }

        public IFieldSnapshot CreateSnapshot()
        {
            var resarr = this.fieldArr.Clone() as IGameObject[,];
            var rob = (Robot)this.robot.Clone();
            return new FieldSnapshot(resarr, rob, this);
        }

        public void SetFieldArr(IGameObject[,] fieldarr1)
        {
            this.fieldArr = fieldarr1;
        }

        public void SetRobot(Robot robot)
        {
            this.robot = robot;
        }

        public bool CanMoveThere(int y, int x)
        {
            if (y < this.GetSizeY() && y > -1)
            {
                if(x < this.GetSizeX() && x > -1)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
