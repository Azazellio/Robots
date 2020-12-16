using BL.Abstr;

namespace BL.Impl.Cargos
{
    public class ProtectedCargo : AbstractCargo
    {
        public bool isProtected;
        public ProtectedCargo(int posX, int posY, int price, int weignt) : base(posX, posY, price, weignt)
        {
            this.isProtected = true;
        }
    }
}
