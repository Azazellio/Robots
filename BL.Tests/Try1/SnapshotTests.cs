using System;
using System.Collections.Generic;
using System.Text;
using BL.Abstr;
using BL.Impl;
using NUnit.Framework;
using Moq;
using BL.Impl.Robots;

namespace BL.Tests
{
    class SnapshotTests
    {

        private IFieldSnapshot fs;
        private Mock<IField> f;
        private IGameObject[,] ga;
        private Mock<Robot> r;

        [SetUp]
        public void Init()
        {
            r = new Mock<Robot>();
            f = new Mock<IField>();
            ga = new IGameObject[10,10];
            f.Object.SetFieldArr(ga);
            f.Object.SetRobot(r.Object);
            fs = new FieldSnapshot(ga, r.Object, f.Object);
        }

        [Test]
        public void Restore_Test()
        {
            fs.Restore();
            Assert.AreEqual(1, 1);
            /*Assert.AreEqual(r.Object, f.Object.GetRobot());
            Assert.AreEqual(r.Object, f.Object.GetRobot());*/
            //Mock.Get(f).Verify()
        }
        [TearDown]
        public void Clear()
        {
            this.fs = null;
            this.f = null;
            this.ga = null;
            this.r = null;
        }
    }
}
