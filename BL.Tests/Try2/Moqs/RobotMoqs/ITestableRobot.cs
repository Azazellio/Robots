using System;
using System.Collections.Generic;
using System.Text;
using BL.Abstr;

namespace BL.Tests.Try2.Moqs.RobotMoqs
{
    interface ITestableRobot
    {
        public void SetRobotId(Guid id);
        public void SetLegend(string legend);
        public void SetBackpackSize(int size);
        public void SetPickPrice(int price);
        public void SetMovePrice(int price);
        public void SetPosX(int pos);
        public void SetPosY(int pos);
        public void SetBackpack(List<AbstractCargo> cargoList);
    }
}
