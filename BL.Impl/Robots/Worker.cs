using BL.Abstr;
using System;

namespace BL.Impl.Robots
{
    class Worker : Robot
    {
        public Worker() : base()
        {
            this.Battery = 150;
            this.BackpackSize = 150;
            this.View = "WO";
        }
    }
}
