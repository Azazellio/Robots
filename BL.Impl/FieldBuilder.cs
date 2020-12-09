using BL.Abstr;
using System;
using BL.Impl.Cargos;
using BL.Impl.CargoFactories;

namespace BL.Impl
{
    public class FieldBuilder : IFieldBuilder
    {

        public FieldBuilder() { }
        private CargoAbstractFactory cargoFactory;

        public IField CreateField(int x, int y, Robot robot)
        {
            var resArr = new IGameObject[x, y];
            robot.PosY = 9;
            robot.PosX = 9;
            resArr[robot.PosX, robot.PosY] = robot;
            int cargoAmount = x;
            var randx = new Random();
            var randy = new Random();

            for(int i = 0; i <= cargoAmount; i++)
            {
                int px = randx.Next(0, x);
                int py = randy.Next(0, y);
                Type typecargo = PickCargoType();
                this.cargoFactory = PickFactory(typecargo);
                var cargo = this.cargoFactory.CreateCargo(px, py);

                if(resArr[px, py] == null)
                {
                    resArr[px, py] = cargo;
                }
            }

            this.FillField(resArr);
            var res = new Field(resArr, robot);
            return res;
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
            else if(picker < 6 & picker > 4 )
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
        private void FillField(IGameObject[,] arr)
        {
            int rowLength = arr.GetLength(0);
            int colLength = arr.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    if (arr[i, j] == null)
                        arr[i, j] = new EmptyElement(i, j);
                }
            }
        }
    }
}
