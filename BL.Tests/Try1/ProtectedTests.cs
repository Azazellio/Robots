using System;
using BL.Abstr;
using BL.Impl;
using BL.Impl.RobotDecorators;
using NUnit.Framework;
using Moq;

namespace BL.Tests
{
    [TestFixture]
    class ProtectedTests
    {
        private Mock<Robot> r;
        private ProtectedRobotDecorator prd;

        [SetUp]
        public void Init()
        {
            r = new Mock<Robot>();
            prd = new ProtectedRobotDecorator();
            prd.SetRobot(r.Object);
        }

        [TearDown]
        public void Clear()
        {
            r = null;
            prd = null;
        }

        [Test]
        public void ProtectedDec_Constr_False()
        {
            Assert.IsFalse(prd.GethasbeenCalled());
        }
    }
}
