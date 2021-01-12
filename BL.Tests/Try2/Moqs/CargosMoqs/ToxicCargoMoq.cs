using BL.Impl.Cargos;
using System;

namespace BL.Tests.Try2.Moqs.CargosMoqs
{
    public class ToxicCargoMoq: ToxicCargo, ITestableCargo
    {
        public ToxicCargoMoq() { }
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
            this.PosX = y;
        }
        public void SetToxicity(bool isToxic)
        {
            this.isToxic = isToxic;
        }
        public override Type GetCompilerTimeType()
        {
            return typeof(ToxicCargo);
        }
    }
}
