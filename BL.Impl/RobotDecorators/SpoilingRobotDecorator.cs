using BL.Abstr;
using BL.Impl.Cargos;
using BL.Impl.Robots;
using System;
using System.Collections.Generic;

namespace BL.Impl.RobotDecorators
{
    public class SpoilingRobotDecorator : AbstractRobotDecorator
    {
        protected int _ActionsUntilSpoiled = -1;
        public AbstractCargo cargoThatSpoils;
        public int ActionsUntilSpoiled
        {
            get { return this._ActionsUntilSpoiled; }
            set
            {
                if (value < 1)
                    DePriceCargo();
                this._ActionsUntilSpoiled = value;
            }
        }
        protected void DePriceCargo()
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

        public override object Clone()
        {
            SpoilingRobotDecorator protdec = new SpoilingRobotDecorator();

            protdec.SetRobot((Robot)this.robot.Clone());

            protdec._ActionsUntilSpoiled = this._ActionsUntilSpoiled;
            protdec.cargoThatSpoils = this.cargoThatSpoils;

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
