using BL.Abstr;
using BL.Impl.Cargos;

namespace BL.Impl.CargoFactories
{
    class CargoFactory : CargoAbstractFactory
    {
        public CargoFactory() { }
        public override AbstractCargo CreateCargo(int posX, int PosY)
        {
            return new Cargo(posX, PosY, 100, 5);
        }
    }
}
