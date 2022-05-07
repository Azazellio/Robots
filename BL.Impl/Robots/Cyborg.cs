using System;
using System.Collections.Generic;
using System.Text;
using BL.Abstr;

namespace BL.Impl.Robots
{
    public class Cyborg : Robot
    {
        public Cyborg() : base()
        {
            this.Battery = 125;
            this.BackpackSize = 125;
        }

        public override object Clone()
        {
            Cyborg cyb = new Cyborg();
            cyb.SetBatteryCustom(this.Battery);
            cyb.Backpack = new List<AbstractCargo>(this.Backpack);
            cyb.BackpackSize = this.BackpackSize;
            cyb.RobotId = this.RobotId;
            cyb.PosX = this.PosX;
            cyb.PosY = this.PosY;
            cyb.movePrice = this.movePrice;
            cyb.pickPrice = this.pickPrice;
            cyb.Legend = this.Legend;

            return cyb;
        }
    }
}
