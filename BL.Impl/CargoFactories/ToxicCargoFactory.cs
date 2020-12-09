using BL.Abstr;
using BL.Impl.Cargos;

namespace BL.Impl.CargoFactories
{
    class ToxicCargoFactory : CargoAbstractFactory
    {
        public ToxicCargoFactory() { }
        public override AbstractCargo CreateCargo(int posX, int PosY)
        {
            return new ToxicCargo(posX, PosY, 100, 5);
        }
    }
}
