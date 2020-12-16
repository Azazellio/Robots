using System;
using System.Collections.Generic;
using System.Text;
using BL.Abstr;

namespace BL.Impl.Robots
{
    public class Cyborg : Robot
    {
        public Cyborg() : base()
        {
            this.Battery = 125;
            this.BackpackSize = 125;
        }

    }
}
