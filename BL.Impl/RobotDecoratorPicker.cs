using System;
using System.Collections.Generic;
using System.Text;
using BL.Abstr;
using BL.Impl.Cargos;
using BL.Impl.DecoratorsCreator;

namespace BL.Impl
{
    public class RobotDecoratorPicker
    {
        private RobotDecoratorAbstractFactory factory;
        public RobotDecoratorPicker()
        {

        }

        public Robot DecorateRobotIfNeeded(Robot robot, AbstractCargo cargo)
        {
            Robot res = null;
            if (cargo.GetType() != typeof(Cargo))
            {
                res = this.DecorateRobot(robot, cargo);
            }
            else
            {
                res = robot;
            }
            return res;
        }

        private Robot DecorateRobot(Robot robot, AbstractCargo cargo)
        {
            if (cargo.GetType() == typeof(ProtectedCargo))
            {
                factory = new ProtectedDecoratorFactory();
            }
            else if(cargo.GetType() == typeof(SpoilableCargo))
            {
                factory = new SpoilingDecoratorFactory();
            }
            else if(cargo.GetType() == typeof(ToxicCargo))
            {
                factory = new ToxicDecoratorFactory();
            }

            return factory.CreateDecorator(robot)
;        }
    }
}
