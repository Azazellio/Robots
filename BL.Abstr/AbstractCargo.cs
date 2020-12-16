
using System;

namespace BL.Abstr
{
    public abstract class AbstractCargo:IGameObject
    {
        public AbstractCargo(int posX, int posY, int price, int weignt)
        {
            this.PosX = posX;
            this.PosY = posY;
            this.Weight = weignt;
            this.Price = price;
        }
        public int Weight;
        public int Price;
        private int PosX;
        private int PosY;

        public int GetPosX { get => this.PosX; set => this.PosX = value; }
        public int GetPosY { get => this.PosY; set => this.PosY = value; }
        public Type GetCompilerTimeType()
        {
            return this.GetType();
        }
    }
}
