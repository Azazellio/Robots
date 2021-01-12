using System;
using System.Collections.Generic;
using System.Text;
using BL.Abstr;

namespace BL.Impl.Cargos
{
    public class Cargo : AbstractCargo
    {
        public Cargo(int posX, int posY, int price, int weignt) : base(posX, posY, price, weignt) { }
        public Cargo() : base() { }

    }
}
