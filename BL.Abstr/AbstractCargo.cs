
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
        public AbstractCargo() { }
        public int Weight;
        public int Price;
        protected int PosX;
        protected int PosY;

        public int GetPosX { get => this.PosX; set => this.PosX = value; }
        public int GetPosY { get => this.PosY; set => this.PosY = value; }
        public virtual Type GetCompilerTimeType()
        {
            return this.GetType();
        }
    }
}
