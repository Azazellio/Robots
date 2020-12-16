using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Abstr
{
    public abstract class Robot:IGameObject
    {
        public Guid PlayerId { get; protected set; }
        protected Guid RobotId;
        public string Legend;
        protected int _Battery;
        protected int BackpackSize;
        protected List<AbstractCargo> _Backpack;
        protected int PosX;
        protected int PosY;
        protected int movePrice;
        protected int pickPrice;
        
        public virtual int GetPosX { get => this.PosX; set => this.PosX = value; }
        public virtual int GetPosY { get => this.PosY; set => this.PosY = value; }
        public virtual int Battery { get => this._Battery; set => this._Battery = value; }
        public virtual List<AbstractCargo> Backpack { get => this._Backpack; set => this._Backpack = value; }
        public virtual int CargoCount { get => this.Backpack.Count; }
        protected Robot()
        {
            this.RobotId = Guid.NewGuid();
            this.Backpack = new List<AbstractCargo>();
            this.movePrice = 4;
            this.pickPrice = 7;
        }
        public void SetPlayerId(Guid playerId)
        {
            if (this.PlayerId != null)
            {
                this.PlayerId = playerId;
            }
        }
        private bool checkBattery(int reducer)
        {
            if (this.Battery < reducer)
                return false;
            return true;
        }
        public virtual void ReduceBattery(int reducer)
        {
            if (this.checkBattery(reducer))
                this.Battery -= reducer;
        }
        public virtual void PickupCargo(AbstractCargo cargo)
        {
            this.Backpack.Add(cargo);
            this.ReduceBattery(pickPrice);
        }
        public virtual bool CanPickCargo(AbstractCargo cargo)
        {
            return this.checkBattery(pickPrice);
        }
        public virtual int CountTreasure()
        {
            var res = 0;
            foreach(var cargo in this.Backpack)
            {
                res += cargo.Price;
            }
            return res;
        }

        protected virtual void MoveLeft()
        {
            this.PosX -= 1;
        }
        protected virtual void MoveRight()
        {
            this.PosX += 1;
        }
        protected virtual void MoveDown()
        {
            this.PosY += 1;
        }
        protected virtual void MoveUp()
        {
            this.PosY -= 1;
        }
        public virtual void ActionMoveLeft()
        {
            this.MoveLeft();
            this.ReduceBattery(movePrice);
        }
        public virtual void ActionMoveRight()
        {
            this.MoveRight();
            this.ReduceBattery(movePrice);
        }
        public virtual void ActionMoveDown()
        {
            this.MoveDown();
            this.ReduceBattery(movePrice);
        }
        public virtual void ActionMoveUp()
        {
            this.MoveUp();
            this.ReduceBattery(movePrice);
        }

        public virtual Type GetCompilerTimeType()
        {
            return this.GetType();
        }
        public override string ToString()
        {
            var res = "";
            res += "y: " + this.GetPosY.ToString() + " x: " + this.GetPosX.ToString() +
                Environment.NewLine + "Battery: " + this.Battery.ToString() +
                Environment.NewLine + "price of cargo: " + this.CountTreasure().ToString() + " count of cargo: " + this.CargoCount.ToString()
                + Environment.NewLine + "Type: " + this.GetType();
            return res;
        }
        public void SetBatteryCustom(int bat)
        {
            this.Battery = bat;
        }
    }
}
