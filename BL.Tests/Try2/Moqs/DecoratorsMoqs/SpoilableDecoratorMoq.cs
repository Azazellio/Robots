using BL.Impl.RobotDecorators;
using BL.Abstr;

namespace BL.Tests.Try2.Moqs.DecoratorsMoqs
{
    public class SpoilableDecoratorMoq: SpoilingRobotDecorator
    {
        public SpoilableDecoratorMoq() { }
        public void SetActionsUntilSpoiled(int actions)
        {
            this._ActionsUntilSpoiled = actions;
        }
        public void DepriceCargoTest()
        {
            this.DePriceCargo();
        }
        public void SetCargoThatSpoils(AbstractCargo cargo)
        {
            this.cargoThatSpoils = cargo;
        }
    }
}
