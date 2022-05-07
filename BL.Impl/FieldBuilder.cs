using BL.Abstr;
using System;
using BL.Impl.Cargos;
using BL.Impl.CargoFactories;

namespace BL.Impl
{
    public class FieldBuilder : IFieldBuilder
    {

        public FieldBuilder()
        {
            this.decorator = new RobotDecoratorPicker();
        }
        private CargoAbstractFactory cargoFactory;
        private Robot robot;
        private IGameObject notPickedCargo;
        private RobotDecoratorPicker decorator;

        public IField CreateField(int x, int y, Robot robot)
        {
            this.robot = robot;
            var resArr = new IGameObject[x, y];
            robot.GetPosY = 0;
            robot.GetPosX = 0;
            resArr[robot.GetPosY, robot.GetPosX] = robot;
            int cargoAmount = x*3;
            var rand = new Random();

            for(int i = 0; i < cargoAmount; i++)
            {
                int px = rand.Next(0, x);
                int py = rand.Next(0, y);
                Type typecargo = PickCargoType();
                this.cargoFactory = PickFactory(typecargo);
                var cargo = this.cargoFactory.CreateCargo(px, py);

                if(resArr[py, px] == null)
                {
                    resArr[py, px] = cargo;
                }
            }

            var res = new Field(resArr, robot);
            return res;
        }
        
        public IField UpdateField(IField field)
        {
/*            if (field.CanMoveThere(robot.GetPosY, robot.GetPosX))
            {

            }*/
            this.robot = field.GetRobot();
            int rowLength = field.GetField().GetLength(0);
            int colLength = field.GetField().GetLength(1);
            var newField = new IGameObject[rowLength, colLength];
            IGameObject[,] oldfield = field.GetField();

            if (this.notPickedCargo != null)
            {
                this.LocateObj(newField, this.notPickedCargo);
                this.notPickedCargo = null;
            }

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    IGameObject obj = oldfield[i, j];
                    if (obj != null)
                    {
                        if (obj is AbstractCargo)
                        {
                            if (robot.GetPosY == i && robot.GetPosX == j)
                            {
                                this.robot = decorator.DecorateRobotIfNeeded(robot, (AbstractCargo)obj);

                                if (robot.CanPickCargo((AbstractCargo)obj))
                                {
                                    robot.PickupCargo((AbstractCargo)obj);
                                    newField[obj.GetPosY, obj.GetPosX] = robot;
                                }
                                else
                                {
                                    this.notPickedCargo = obj;
                                    newField[obj.GetPosY, obj.GetPosX] = robot;
                                }
                            }
                            newField[obj.GetPosY, obj.GetPosX] = obj;
                        }
                    }
                }
            }
            this.LocateObj(newField, robot);
            field.SetFieldArr(newField);
            field.SetRobot(robot);
            return field;
        }
        private void LocateObj(IGameObject [,] field, IGameObject obj)
        {
            field[obj.GetPosY, obj.GetPosX] = obj;
        }
        private Type PickCargoType()
        {
            Type type = typeof(Cargo);
            Random rand = new Random();
            int picker = rand.Next(0, 10);

            if(picker < 2)
            {
                type = typeof(ToxicCargo);
            }
            else if(picker < 4 & picker > 2)
            {
                type = typeof(SpoilableCargo);
            }
            else if(picker < 9 & picker > 4 )
            {
                type = typeof(ProtectedCargo);
            }
            return type;
        }
        private CargoAbstractFactory PickFactory(Type type1)
        {
            CargoAbstractFactory res = null;

            if (type1 == typeof(ToxicCargo))
            {
                res = new ToxicCargoFactory();
            }
            else if (type1 == typeof(SpoilableCargo))
            {
                res = new SpoilableCargoFactory();
            }
            else if (type1 == typeof(ProtectedCargo))
            {
                res = new ProtectedCargoFactory();
            }
            else if (type1 == typeof(Cargo))
            {
                res = new CargoFactory();
            }

            return res;
        }
    }
}
