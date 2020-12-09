using System;
using System.Collections.Generic;
using System.Text;
using BL.Abstr;

namespace BL.Impl.Robots
{
    class Cyborg : Robot
    {
        public Cyborg() : base()
        {
            this.Battery = 125;
            this.BackpackSize = 125;
            this.View = "CB";
        }

    }
}
