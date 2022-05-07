using NUnit.Framework;
using BL.Abstr;
using BL.Impl;
using BL.Tests.Try2.Moqs.RobotMoqs;
using System.Collections.Generic;
using BL.Impl.RobotDecorators;
using BL.Tests.Try2.Moqs.CargosMoqs;
using System;

namespace BL.Tests.Try2.Tests
{
    [TestFixture]
    public class ToxicDecoratorTest
    {
        private CyborgMoq rob;
        private ToxicRobotDecorator trobDec;

        [SetUp]
        public void Init()
        {
            rob = new CyborgMoq();
            rob.SetPlayerId(Guid.NewGuid());
            trobDec = new ToxicRobotDecorator();
            trobDec.SetRobot(rob);
        }
        [TearDown]
        public void Clear()
        {
            rob = null;
            trobDec = null;
        }

        [Test]
        public void Robot_PickupCargo()
        {
            var c = new CargoMoq();
            trobDec.PickupCargo(c);
            Assert.IsTrue(trobDec.Backpack.Count == 1);
        }

        [Test]
        public void Robot_PickupToxicCargo()
        {
            var c = new ToxicCargoMoq();
            c.SetToxicity(true);
            rob.SetBackpack(new List<AbstractCargo>());
            rob.SetBatteryCustom(1000);
            rob.SetPickPrice(1);

            trobDec.PickupCargo(c);
            Assert.IsTrue(trobDec.Battery == 994);
        }
        [TestCase(10, 0)]
        [TestCase(100, 90)]
        public void Robot_ActionMove(int battery, int expected)
        {
            var c = new ToxicCargoMoq();
            c.SetToxicity(true);
            rob.SetPickPrice(1);
            rob.SetMovePrice(1);
            rob.SetPosX(10);
            rob.SetPosY(10);
            trobDec.SetBatteryCustom(battery);

            trobDec.PickupCargo(c);
            trobDec.ActionMoveLeft();
            Assert.IsTrue(trobDec.Battery == expected);
        }
    }
}
