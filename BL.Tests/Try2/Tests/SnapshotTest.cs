using BL.Abstr;
using BL.Impl;
using BL.Tests.Try2.Moqs;
using BL.Tests.Try2.Moqs.RobotMoqs;
using NUnit.Framework;

namespace BL.Tests.Try2.Tests
{
    [TestFixture]
    public class SnapshotTest
    {
        private FieldMoq field;
        private WorkerMoq robot;

        [SetUp]
        public void Init()
        {
            field = new FieldMoq();
            robot = new WorkerMoq();

        }
        [TearDown]
        public void Clear()
        {
            field = null;
            robot = null;
        }

        [Test]
        public void SnapShop_Restore()
        {
            var arr = new IGameObject[5,5];
            field.SetFieldArr(arr);
            field.SetRobot(robot);
            var snap1 = field.CreateSnapshot();

            var arr1 = new IGameObject[10,10];
            field.SetFieldArr(arr1);

            var snap2 = field.CreateSnapshot();

            snap1.Restore();
            Assert.AreEqual(arr.Length, field.GetField().Length);

        }

    }
}
