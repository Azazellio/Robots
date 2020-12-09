using BL.Abstr;
using BL.Impl.Cargos;
using BL.Impl.Robots;
using System;

namespace BL.Impl.RobotDecorators
{
    class ProtectedRobotDecorator : AbstractRobotDecorator
    {
        public ProtectedRobotDecorator() : base() { }

        public override void PickupCargo(AbstractCargo cargo)
        {
            if (this.CanPickUpCargo(cargo))
            {
                base.PickupCargo(cargo);
            }
        }

        private bool CanPickUpCargo(AbstractCargo cargo)
        {
            if (cargo.GetType() == typeof(ProtectedCargo))
            {
                var rand = new Random();
                var integ = rand.Next(0, 100);

                if (this.robot.GetType() == typeof(BrightMind))
                {
                    return true;
                }
                else if (this.robot.GetType() == typeof(Cyborg))
                {
                    if (integ < 60)
                    {
                        return true;
                    }
                    return false;
                }
                else if (this.robot.GetType() == typeof(Worker))
                {
                    if (integ < 10)
                    {
                        return true;
                    }
                    return false;
                }
            }
            return true;
        }
    }
}
