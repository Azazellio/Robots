using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Abstr
{
    public interface IRobotProducer
    {
        public Robot PickRobot(Guid playrId);

    }
}
