using BL.Impl.Cargos;

namespace BL.Tests.Try2.Moqs.CargosMoqs
{
    public class CargoMoq : Cargo, ITestableCargo
    {
        public CargoMoq(int posX, int posY, int price, int weignt) : base(posX, posY, price, weignt) { }
        public CargoMoq() { }

        public void SetPrice(int price)
        {
            this.Price = price;
        }

        public void SetWeight(int weight)
        {
            this.Weight = weight;
        }

        public void SetPosXY(int x, int y)
        {
            this.PosX = x;
            this.PosY = y;
        }
    }
}
