using BL.Abstr;
using BL.Impl.Cargos;

namespace BL.Impl.CargoFactories
{
    class ProtectedCargoFactory : CargoAbstractFactory
    {
        public ProtectedCargoFactory() { }
        public override AbstractCargo CreateCargo(int posX, int PosY)
        {
            return new ProtectedCargo(posX, PosY, 150, 5);
        }
    }
}
