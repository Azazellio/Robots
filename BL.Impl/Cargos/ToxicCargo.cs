using BL.Abstr;

namespace BL.Impl.Cargos
{
    class ToxicCargo : AbstractCargo
    {
        public bool isToxic;
        public ToxicCargo(int posX, int posY, int price, int weignt) : base(posX, posY, price, weignt)
        {
            this.isToxic = true;
            this.View = "ct";
        }
    }
}
