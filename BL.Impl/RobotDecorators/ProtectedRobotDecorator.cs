using BL.Abstr;
using BL.Impl.Cargos;
using BL.Impl.Robots;
using System;

namespace BL.Impl.RobotDecorators
{
    public class ProtectedRobotDecorator : AbstractRobotDecorator
    {
        public ProtectedRobotDecorator() : base() { }

        public override bool CanPickCargo(AbstractCargo cargo)
        {
            if (robot.CanPickCargo(cargo))
            {
                if (cargo.GetType() == typeof(ProtectedCargo))
                {
                    var rand = new Random();
                    var integ = rand.Next(0, 100);

                    if (this.robot.GetCompilerTimeType() == typeof(BrightMind))
                    {
                        return true;
                    }
                    else if (this.robot.GetCompilerTimeType() == typeof(Cyborg))
                    {
                        if (integ < 60)
                        {
                            return true;
                        }
                        return false;
                    }
                    else if (this.robot.GetCompilerTimeType() == typeof(Worker))
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
            return false;
        }
    }
}
