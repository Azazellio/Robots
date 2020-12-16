using BL.Abstr;
using BL.Impl.Cargos;
using BL.Impl.Robots;
using System;

namespace BL.Impl.RobotDecorators
{
    public class SpoilingRobotDecorator : AbstractRobotDecorator
    {
        private int _ActionsUntilSpoiled = -1;
        private AbstractCargo cargoThatSpoils;
        public int ActionsUntilSpoiled
        {
            get { return this._ActionsUntilSpoiled; }
            private set
            {
                if (value < 1)
                    DePriceCargo();
                this._ActionsUntilSpoiled = value;
            }
        }
        private void DePriceCargo()
        {
            this.cargoThatSpoils.Price = 0;
        }
        public SpoilingRobotDecorator() : base() { }

        public override void PickupCargo(AbstractCargo cargo)
        {
            this.SpoilCargo();
            if (cargo.GetType() == typeof(SpoilableCargo))
            {
                this.cargoThatSpoils = cargo;
                this.ActionsUntilSpoiled = 10;
            }
            this.robot.PickupCargo(cargo);
        }
        private void SpoilCargo()
        {
            if (this._ActionsUntilSpoiled != -1)
                this.ActionsUntilSpoiled--;
        }
        public override void ActionMoveUp()
        {
            this.SpoilCargo();
            robot.ActionMoveUp();
        }
        public override void ActionMoveDown()
        {
            this.SpoilCargo();
            robot.ActionMoveDown();
        }
        public override void ActionMoveLeft()
        {
            this.SpoilCargo();
            robot.ActionMoveLeft();
        }
        public override void ActionMoveRight()
        {
            this.SpoilCargo();
            robot.ActionMoveRight();
        }
    }
}
