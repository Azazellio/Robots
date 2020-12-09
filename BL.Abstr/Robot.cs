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
        protected int Battery;
        protected int BackpackSize;
        protected string View = "R";
        public int PosX;
        public int PosY;
        protected Robot()
        {
            this.RobotId = Guid.NewGuid();
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
        protected void ReduceBattery(int reducer)
        {
            if (this.checkBattery(reducer))
                this.Battery -= reducer;
        }
        protected List<AbstractCargo> Backpack;
        public virtual void PickupCargo(AbstractCargo cargo)
        {
            this.Backpack.Add(cargo);
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
            this.ReduceBattery(5);
        }
        public virtual void ActionMoveRight()
        {
            this.MoveRight();
            this.ReduceBattery(5);
        }
        public virtual void ActionMoveDown()
        {
            this.MoveDown();
            this.ReduceBattery(5);
        }
        public virtual void ActionMoveUp()
        {
            this.MoveUp();
            this.ReduceBattery(5);
        }

        public string GetView()
        {
            return this.View;
        }

        public int GetPosX()
        {
            return this.PosX;
        }

        public int GetPosY()
        {
            return this.PosY;
        }

        public void Destroy()
        {
            this.View = " ";
        }
    }
}
