using System;
using BL.Abstr;
using BL.Impl;
using BL.Impl.RobotDecorators;
using NUnit.Framework;
using Moq;

namespace BL.Tests
{
    [TestFixture]
    public class SpoilingDecoratorTests
    {

        private Mock<Robot> r;
        private SpoilingRobotDecorator srd;
        [SetUp]
        public void Init()
        {
            r = new Mock<Robot>();
            srd = new SpoilingRobotDecorator();
            srd.SetRobot(r.Object);
        }

        [TearDown]
        public void Clear()
        {
            r = null;
            srd = null;
        }

        [TestCase(2, 1)]
        [TestCase(15, 14)]
        [TestCase(10, 9)]
        public void SpoilDec_Spoil_9(int x, int expected)
        {
            srd.ActionsUntilSpoiled = x;
            srd.ActionMoveDown();
            Assert.AreEqual(expected, srd.ActionsUntilSpoiled);
        }

        [TestCase(100, 0)]
        [TestCase(1100, 0)]
        [TestCase(1, 0)]
        public void SpoilDec_DepriceCargo_0(int price, int expected)
        {
            Mock<AbstractCargo> c = new Mock<AbstractCargo>();
            c.Object.Price = price;
            srd.PickupCargo(c.Object);
            srd.cargoThatSpoils = c.Object;
            srd.ActionsUntilSpoiled = 0;
            Assert.AreEqual(expected, srd.cargoThatSpoils.Price);
        }

    }
}
