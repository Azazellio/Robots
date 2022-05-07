using BL.Abstr;
using System;

namespace BL.Impl
{
    public class EmptyElement : IGameObject
    {
        public EmptyElement(int posx, int posy)
        {
            this.posX = posx;
            this.posY = posy;
        }
        private int posX;
        private int posY;


        int IGameObject.GetPosX { get => this.posX; set => this.posX = value ; }
        int IGameObject.GetPosY { get => this.posY; set => this.posY = value; }

        public Type GetCompilerTimeType()
        {
            return this.GetType();
        }
    }
}
