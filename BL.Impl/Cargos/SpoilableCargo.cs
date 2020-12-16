using BL.Abstr;

namespace BL.Impl.Cargos
{
    public class SpoilableCargo : AbstractCargo
    {
        public int UntilSpoils;
        public SpoilableCargo(int posX, int posY, int price, int weignt) : base(posX, posY, price, weignt)
        {
            this.UntilSpoils = 20;
        }
    }
}
