using BL.Abstr;
using System.Collections.Generic;

namespace BL.Impl
{
    class Field : IField
    {
        private IGameObject[,] fieldArr;
        private Robot robot;

        public Field(IGameObject[,] field, Robot robot)
        {
            this.fieldArr = field;
            this.robot = robot;
        }

        public Robot GetRobot()
        {
            return this.robot;
        }

        public int GetSizeX()
        {
            return this.fieldArr.GetLength(0);
        }

        public int GetSizeY()
        {
            return this.fieldArr.GetLength(1);
        }

        public IGameObject[,] GetField()
        {
            return this.fieldArr;
        }

        public IFieldSnapshot CreateSnapshot()
        {
            //var resarr = new IGameObject[this.fieldArr.GetLength(0), this.fieldArr.GetLength(1)];
            var resarr = this.fieldArr.Clone() as IGameObject[,];
            return new FieldSnapshot(resarr, (Robot)this.robot.Clone(), this) ;
        }

        public void SetFieldArr(IGameObject[,] fieldarr1)
        {
            this.fieldArr = fieldarr1;
        }

        public void SetRobot(Robot robot)
        {
            this.robot = robot;
        }
    }
}
