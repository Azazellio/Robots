using BL.Impl.RobotDecorators;
using BL.Abstr;

namespace BL.Tests.Try2.Moqs.DecoratorsMoqs
{
    public class ToxicDecoratorMoq: ToxicRobotDecorator
    {
        public ToxicDecoratorMoq() { }

        public void SetToxicActions(int actoins)
        {
            this.toxicActions = actoins;
        }
        public void SetToxicMovePrice(int price)
        {
            this.toxicMovePrice = price;
        }
        public void SetToxicPickupPrice(int price)
        {
            this.toxicPickupPrice = price;
        }

    }
}
