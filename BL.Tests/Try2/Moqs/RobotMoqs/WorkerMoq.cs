using System;
using System.Collections.Generic;
using BL.Abstr;
using BL.Impl.Robots;

namespace BL.Tests.Try2.Moqs.RobotMoqs
{
    class WorkerMoq : Worker, ITestableRobot
    {
        public WorkerMoq() { }
        public void SetBackpack(List<AbstractCargo> cargoList)
        {
            this.Backpack = cargoList;
        }

        public void SetBackpackSize(int size)
        {
            this.BackpackSize = size;
        }

        public void SetLegend(string legend)
        {
            this.Legend = legend;
        }

        public void SetMovePrice(int price)
        {
            this.movePrice = price;
        }

        public void SetPickPrice(int price)
        {
            this.pickPrice = price;
        }

        public void SetPosX(int pos)
        {
            this.PosX = pos;
        }

        public void SetPosY(int pos)
        {
            this.PosY = pos;
        }

        public void SetRobotId(Guid id)
        {
            this.RobotId = id;
        }

        ////////////////////////
        


    }
}
