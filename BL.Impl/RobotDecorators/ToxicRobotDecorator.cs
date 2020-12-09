using BL.Abstr;
using BL.Impl.Cargos;
using BL.Impl.Robots;
using System;

namespace BL.Impl.RobotDecorators
{
    class ToxicRobotDecorator : AbstractRobotDecorator
    {
        private int ToxicActions = 0;
        public ToxicRobotDecorator() : base() { }
        public override void PickupCargo(AbstractCargo cargo)
        {
            DecoratedPickup(cargo);
            this.robot.PickupCargo(cargo);
        }
        
        public void DecoratedPickup(AbstractCargo cargo)
        {
            if (cargo.GetType() == typeof(ToxicCargo) && this.robot.GetType() == typeof(Cyborg))
            {
                this.ToxicActions += 10;
                this.ReduceBattery(10);
                this.ReduceToxicActionPickUp();
            }
        }
        private void ReduceToxicActionPickUp()
        {
            if (this.ToxicActions > 0)
            {
                this.ReduceBattery(4);
                this.ToxicActions -= 1;
            }
        }
        private void ReduceToxicActionMove()
        {
            if (this.ToxicActions > 0)
            {
                this.ReduceBattery(3);
                this.ToxicActions -= 1;
            }
        }
        protected override void MoveLeft()
        {
            base.MoveLeft();
            ReduceToxicActionMove();
        }
        protected override void MoveRight()
        {
            base.MoveRight();
            ReduceToxicActionMove();
        }
        protected override void MoveDown()
        {
            base.MoveDown();
            ReduceToxicActionMove();
        }
        protected override void MoveUp()
        {
            base.MoveUp();
            ReduceToxicActionMove();
        }

    }
}
