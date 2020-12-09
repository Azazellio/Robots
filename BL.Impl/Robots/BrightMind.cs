using BL.Abstr;
using System;

namespace BL.Impl.Robots
{
    class BrightMind : Robot
    {
        public BrightMind() : base()
        {
            this.Battery = 100;
            this.View = "BM";
        }
    }
}
