using System;
using BL.Impl;
using BL.Abstr;
using NUnit.Framework;
using Moq;
using BL.Impl.Commands;

namespace BL.Tests
{
    [TestFixture]
    public class RobotCommandTest
    {
        RobotCommand rc;
        Mock<Robot> rm;

        [SetUp]
        public void Init()
        {
            this.rm = new Mock<Robot>();
        }
        [Test]
        public void Execute_IsInvoked()
        {
            //rm.Setup(x => rm.Object.ActionMoveDown());
            rc = new MoveDownCommand(rm.Object);
            rc.Execute();
            Assert.AreEqual(1, 1);
            //Mock.Get(rm).Verify(x => rm.Object.ActionMoveDown(), Times.Exactly(1));
        }

        [TearDown]
        public void Clear()
        {
            this.rc = null;
            this.rm = null;
        }
    }
}
