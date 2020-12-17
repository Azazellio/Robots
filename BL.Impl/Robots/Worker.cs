using BL.Abstr;
using System;
using System.Collections.Generic;

namespace BL.Impl.Robots
{
    public class Worker : Robot
    {
        public Worker() : base()
        {
            this.Battery = 150;
            this.BackpackSize = 150;
        }

        public override object Clone()
        {
            Worker wor = new Worker();

            wor.SetBatteryCustom(this.Battery);
            wor.Backpack = new List<AbstractCargo>(this.Backpack);
            wor.BackpackSize = this.BackpackSize;
            wor.RobotId = this.RobotId;
            wor.PosX = this.PosX;
            wor.PosY = this.PosY;
            wor.movePrice = this.movePrice;
            wor.pickPrice = this.pickPrice;
            wor.Legend = this.Legend;

            return wor;
        }
    }
}
