using BL.Abstr;
using BL.Impl.Cargos;
using BL.Impl.Robots;
using System;

namespace BL.Impl.RobotDecorators
{
    class SpoilingRobotDecorator : AbstractRobotDecorator
    {
        private int _ActionsUntilSpoiled = -1;
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
        private AbstractCargo cargoThatSpoils;
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
                this.ActionsUntilSpoiled = 15;
            }
            base.PickupCargo(cargo);
        }
        private void SpoilCargo()
        {
            if (this._ActionsUntilSpoiled != -1)
                this.ActionsUntilSpoiled--;
        }
        protected override void MoveUp()
        {
            this.SpoilCargo();
            base.MoveUp();
        }
        protected override void MoveDown()
        {
            this.SpoilCargo();
            base.MoveDown();
        }
        protected override void MoveLeft()
        {
            this.SpoilCargo();
            base.MoveLeft();
        }
        protected override void MoveRight()
        {
            this.SpoilCargo();
            base.MoveRight();
        }
    }
}
