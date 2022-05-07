using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Abstr
{
    public abstract class RobotDecoratorAbstractFactory
    {
        public abstract AbstractRobotDecorator CreateDecorator(Robot robot);
    }
}
