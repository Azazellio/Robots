using NUnit.Framework;
using BL.Abstr;
using BL.Impl;
using BL.Impl.RobotDecorators;
using BL.Impl.Robots;
using BL.Impl.DecoratorsCreator;
using BL.Impl.Cargos;
using System;
using Moq;

namespace BL.Tests
{
    [TestFixture]
    public class DecoratorTests
    {
        private Mock<Robot> r;
        private ToxicRobotDecorator tx;
        [SetUp]
        public void Init()
        {

            r = new Mock<Robot>();
            //r.Object.Battery
            tx = new ToxicRobotDecorator();
            tx.SetRobot(r.Object);
            r.Object.SetBatteryCustom(10000);
        }

        [Test]
        public void ToxicDec_Battery_Test()
        {
            tx.ReduceBattery(10);
            Assert.AreEqual(r.Object.Battery, tx.Battery);
        }
        [Test]
        public void ToxicDec_Pickup_Test()
        {
            var c = new Mock<ToxicCargo>();
            tx.PickupCargo(c.Object);
            Assert.AreEqual(tx.Backpack, r.Object.Backpack);
        }
        [Test]
        public void ToxicDec_MovePrice_Test()
        {
            tx.ActionMoveDown();
            Assert.AreEqual(tx.Battery, r.Object.Battery);
        }

        [TearDown]
        public void Clear()
        {
            this.r = null;
            this.tx = null;
        }
    }
}
