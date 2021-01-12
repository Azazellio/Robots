using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Tests.Try2.Moqs.CargosMoqs
{
    interface ITestableCargo
    {
        public void SetPrice(int price);
        public void SetWeight(int weight);
        public void SetPosXY(int x, int y);
    }
}
