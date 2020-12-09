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

        public void ScanField()
        {
            //this.fieldArr[this.robot.PosX, this.robot.PosY] = robot;

            var newField = new IGameObject[fieldArr.GetLength(0), fieldArr.GetLength(1)];

            int rowLength = newField.GetLength(0);
            int colLength = newField.GetLength(1);

           for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    var old = fieldArr[i, j];
                    newField[old.GetPosX(), old.GetPosY()] = old;
                    
                }
            }
            this.fieldArr = newField;
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
    }
}
