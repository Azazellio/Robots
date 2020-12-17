using BL.Abstr;
using BL.Impl.Cargos;
using BL.Impl.Robots;
using System;
using System.Collections.Generic;

namespace BL.Impl.RobotDecorators
{
    public class ProtectedRobotDecorator : AbstractRobotDecorator
    {
    private bool hasBeenCalled;
    public ProtectedRobotDecorator() : base()
        {
            hasBeenCalled = false;
        }
        public override bool CanPickCargo(AbstractCargo cargo)
        {
            if (robot.CanPickCargo(cargo))
            {
                if (this.hasBeenCalled == true)
                {
                    return true;
                }
                if (cargo.GetType() == typeof(ProtectedCargo))
                {
                    this.hasBeenCalled = true;
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

        public override object Clone()
        {
            ProtectedRobotDecorator protdec = new ProtectedRobotDecorator();

            protdec.SetRobot((Robot)this.robot.Clone());
            protdec.hasBeenCalled = this.hasBeenCalled;

            protdec.SetBatteryCustom(this.Battery);
            protdec.Backpack = new List<AbstractCargo>(this.Backpack);
            protdec.BackpackSize = this.BackpackSize;
            protdec.RobotId = this.RobotId;
            protdec.PosX = this.PosX;
            protdec.PosY = this.PosY;
            protdec.movePrice = this.movePrice;
            protdec.pickPrice = this.pickPrice;
            protdec.Legend = this.Legend;

            return protdec;
        }
    }
}
