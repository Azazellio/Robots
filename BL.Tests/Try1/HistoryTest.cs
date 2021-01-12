using System;
using System.Collections.Generic;
using System.Text;
using BL.Impl;
using BL.Abstr;
using NUnit.Framework;
using Moq;

namespace BL.Tests
{
    [TestFixture]
    public class HistoryTest
    {
        public History h;
        [SetUp]
        public void Init()
        {
            h = new History();
        }
        [Test]
        public void Push_Test()
        {
            Mock<RobotCommand> rc = new Mock<RobotCommand>();
            Mock<IFieldSnapshot> fs = new Mock<IFieldSnapshot>();
            rc.Object.AddBackup(fs.Object);

            h.Push(rc.Object);
            Assert.IsTrue(h.Count == 1);
        }

        [Test]
        public void Undo_Test()
        {
            Mock<RobotCommand> rc = new Mock<RobotCommand>();
            Mock<IFieldSnapshot> fs = new Mock<IFieldSnapshot>();
            rc.Object.AddBackup(fs.Object);
            h.Push(rc.Object);
            h.Undo();
            Assert.IsTrue(h.Count == 0);

        }
        [TearDown]
        public void Clear()
        {
            this.h = null;
        }
    }
}
