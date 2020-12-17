using BL.Abstr;
using System;
using System.Collections.Generic;

namespace BL.Impl.Robots
{
    public class BrightMind : Robot
    {
        public BrightMind() : base()
        {
            this.Battery = 100;
        }

        public override object Clone()
        {
            BrightMind brightMind = new BrightMind();
            brightMind.SetBatteryCustom(this.Battery);
            brightMind.Backpack = new List<AbstractCargo>(this.Backpack);
            brightMind.BackpackSize = this.BackpackSize;
            brightMind.RobotId = this.RobotId;
            brightMind.PosX = this.PosX;
            brightMind.PosY = this.PosY;
            brightMind.movePrice = this.movePrice;
            brightMind.pickPrice = this.pickPrice;
            brightMind.Legend = this.Legend;
            
            return brightMind;
        }
    }
}
