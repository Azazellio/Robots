using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using BL.Impl;
using BL.Impl.Robots;
using Moq;
using BL.Abstr;

namespace BL.Tests.RobotsTests
{
    [TestFixture]
    public class FactoryTests
    {
        private RobotProducer rp;

        [SetUp]
        public void Init()
        {
            this.rp = new RobotProducer();
        }

        [Test]
        public void RobotProducer_GetCase()
        {
            var id = Guid.NewGuid();
            var res = this.rp.PickRobot(id);
            Assert.IsTrue(res.PlayerId == id);
        }

        [OneTimeTearDown]
        public void Final()
        {
            this.rp = null;
        }
    }
}
