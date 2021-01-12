using NUnit.Framework;
using BL.Abstr;
using BL.Impl;
using System;

namespace BL.Tests.Try2.Tests
{
    [TestFixture]
    public class RobotFactoryTest
    {
        private RobotProducer prod;

        [SetUp]
        public void Init()
        {
            prod = new RobotProducer();
        }
        [TearDown]
        public void Clear()
        {
            prod = null;
        }

        [Test]
        public void Producer_Pickrobot_isRobot()
        {
            var id = Guid.NewGuid();
            var rob = prod.PickRobot(id);
            Assert.IsTrue(rob is Robot);
        }

    }
}
