using BL.Abstr;
using BL.Impl.Cargos;
using BL.Impl.Robots;
using System;

namespace BL.Impl.RobotDecorators
{
    class ToxicRobotDecorator : AbstractRobotDecorator
    {
        private int toxicActions;
        private int toxicActionPrice;
        public ToxicRobotDecorator() : base()
        {
            this.toxicActions = 0;
            this.toxicActionPrice = 3;
        }
        public override void PickupCargo(AbstractCargo cargo)
        {
            DecoratedPickup(cargo);
            this.robot.PickupCargo(cargo);
        }
        
        private void DecoratedPickup(AbstractCargo cargo)
        {
            if (cargo.GetType() == typeof(ToxicCargo) && this.robot.GetCompilerTimeType() == typeof(Cyborg))
            {
                this.toxicActions = 10;
                this.ReduceToxicActionPickUp();
            }
        }
        private void ReduceToxicActionPickUp()
        {
            if (this.toxicActions > 0)
            {
                this.robot.ReduceBattery(toxicActionPrice + 1);
                this.toxicActions -= 1;
            }
        }
        private void ReduceToxicActionMove()
        {
            if (this.toxicActions > 0)
            {
                this.robot.ReduceBattery(toxicActionPrice);
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
    }
}
