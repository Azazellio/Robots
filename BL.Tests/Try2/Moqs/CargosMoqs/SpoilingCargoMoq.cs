using BL.Impl.Cargos;

namespace BL.Tests.Try2.Moqs.CargosMoqs
{
    class SpoilingCargoMoq: SpoilableCargo, ITestableCargo
    {
        public SpoilingCargoMoq() { }

        public void SetPosXY(int x, int y)
        {
            this.PosX = x;
            this.PosY = y;
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
