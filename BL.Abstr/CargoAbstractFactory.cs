using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Abstr
{
    public abstract class CargoAbstractFactory
    {
        public abstract AbstractCargo CreateCargo(int posX, int posY);
    }
}
