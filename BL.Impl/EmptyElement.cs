using BL.Abstr;

namespace BL.Impl
{
    class EmptyElement : IGameObject
    {
        public EmptyElement(int posx, int posy)
        {
            this.View = "|_|";
            this.posX = posx;
            this.posY = posy;
        }
        private int posX;
        private int posY;

        private string View;
        public void Destroy()
        {
            this.View = " ";
        }

        public string GetView()
        {
            return this.View;
        }

        public int GetPosX()
        {
            return this.posX;
        }

        public int GetPosY()
        {
            return this.posY;
        }
    }
}
