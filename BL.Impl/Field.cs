using BL.Abstr;
using System.Collections.Generic;

namespace BL.Impl
{
    class Field : IField
    {
        public Field(IGameObject[,] field, Robot robot)
        {
            this.fieldArr = field;
            this.robot = robot;
        }
        private IGameObject[,] fieldArr;
        private Robot robot;

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
    }
}
