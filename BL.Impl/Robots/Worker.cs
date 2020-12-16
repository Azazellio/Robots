using BL.Abstr;
using System;

namespace BL.Impl.Robots
{
    public class Worker : Robot
    {
        public Worker() : base()
        {
            this.Battery = 150;
            this.BackpackSize = 150;
        }
    }
}
