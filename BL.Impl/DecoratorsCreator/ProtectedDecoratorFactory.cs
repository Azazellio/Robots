﻿using BL.Abstr;
using BL.Impl.RobotDecorators;

namespace BL.Impl.DecoratorsCreator
{
    class ProtectedDecoratorFactory : RobotAbstractFactory
    {
        public override Robot CreateRobot()
        {
            return new ProtectedRobotDecorator();
        }
    }
}