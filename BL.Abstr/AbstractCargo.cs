using System;
using System.Collections.Generic;
using System.Text;

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
        public int PosX;
        public int PosY;

        protected string View;

        public string GetView()
        {
            return this.View;
        }

        public int GetPosX()
        {
            return this.PosX;
        }

        public int GetPosY()
        {
            return this.PosY;
        }

        public void Destroy()
        {
            this.View = " ";
        }
    }
}
