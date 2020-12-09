using BL.Abstr;
using BL.Impl.Cargos;

namespace BL.Impl.CargoFactories
{
    class SpoilableCargoFactory : CargoAbstractFactory
    {
        public SpoilableCargoFactory() { }
        public override AbstractCargo CreateCargo(int posX, int PosY)
        {
            return new SpoilableCargo(posX, PosY, 150, 5);
        }
    }
}
