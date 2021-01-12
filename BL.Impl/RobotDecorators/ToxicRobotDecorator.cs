using BL.Abstr;
using BL.Impl.Cargos;
using BL.Impl.Robots;
using System.Collections.Generic;

namespace BL.Impl.RobotDecorators
{
    public class ToxicRobotDecorator : AbstractRobotDecorator
    {
        public int toxicActions { get; protected set; }
        protected int toxicMovePrice;
        protected int toxicPickupPrice;
        public int toxicActionsCount;
        public ToxicRobotDecorator() : base()
        {
            this.toxicActions = 0;
            this.toxicMovePrice = 3;
            this.toxicPickupPrice = 5;
            this.toxicActionsCount = 10;
        }
        public override void PickupCargo(AbstractCargo cargo)
        {
            DecoratedPickup(cargo);
            this.robot.PickupCargo(cargo);
        }
        
        protected void DecoratedPickup(AbstractCargo cargo)
        {
            if (cargo.GetCompilerTimeType() == typeof(ToxicCargo) && this.robot.GetCompilerTimeType() == typeof(Cyborg))
            {
                this.toxicActions = this.toxicActionsCount;
                this.ReduceToxicActionPickUp();
            }
        }
        private void ReduceToxicActionPickUp()
        {
            if (this.toxicActions > 0)
            {
                this.robot.ReduceBattery(toxicPickupPrice);
                this.toxicActions -= 1;
            }
        }
        private void ReduceToxicActionMove()
        {
            if (this.toxicActions > 0)
            {
                this.robot.ReduceBattery(toxicMovePrice);
                this.toxicActions -= 1;
            }
        }
        public override void ActionMoveLeft()
        {
            ReduceToxicActionMove();
            this.robot.ActionMoveLeft();
        }
        public override void ActionMoveRight()
        {
            ReduceToxicActionMove();
            this.robot.ActionMoveRight();
        }
        public override void ActionMoveDown()
        {
            ReduceToxicActionMove();
            this.robot.ActionMoveDown();
        }
        public override void ActionMoveUp()
        {
            ReduceToxicActionMove();
            this.robot.ActionMoveUp();
        }

        public override object Clone()
        {
            ToxicRobotDecorator protdec = new ToxicRobotDecorator();

            protdec.SetRobot((Robot)this.robot.Clone());

            protdec.toxicMovePrice = this.toxicMovePrice;
            protdec.toxicPickupPrice = this.toxicPickupPrice;
            protdec.toxicActions = this.toxicActions;

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
