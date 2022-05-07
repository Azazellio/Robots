using BL.Impl.Cargos;

namespace BL.Tests.Try2.Moqs.CargosMoqs
{
    public class ProtectedCargoMoq : ProtectedCargo, ITestableCargo
    {
        public ProtectedCargoMoq(int posX, int posY, int price, int weignt) : base(posX, posY, price, weignt) { }
        public ProtectedCargoMoq() : base() { }

        public void SetPosXY(int x, int y)
        {
            this.PosY = y;
            this.PosX = x;
        }

        public void SetPrice(int price)
        {
            this.Price = price;
        }

        public void SetWeight(int weight)
        {
            this.Weight = weight;
        }
    }
}
