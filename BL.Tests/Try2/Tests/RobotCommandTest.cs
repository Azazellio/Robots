using BL.Abstr;
using BL.Impl;
using BL.Impl.Commands;
using BL.Tests.Try2.Moqs.RobotMoqs;
using NUnit.Framework;

namespace BL.Tests.Try2.Tests
{
    [TestFixture]
    public class RobotCommandTest
    {
        private MoveUpCommand cmd;
        private WorkerMoq robot;

        [SetUp]
        public void Init()
        {
            robot = new WorkerMoq();
            cmd = new MoveUpCommand(robot);
        }
        [TearDown]
        public void CLear()
        {
            robot = null;
            cmd = null;
        }

        [TestCase(10, 10, 10, 9)]
        [TestCase(1, 1, 1, 0)]
        [TestCase(5, 5, 5, 4)]
        public void MoveUpCommand_Execute(int posX, int posY, int expectedX, int expectedY)
        {
            robot.SetPosX(posX);
            robot.SetPosY(posY);

            cmd.Execute();

            Assert.IsTrue(robot.GetPosY == expectedY);
            Assert.IsTrue(robot.GetPosX == expectedX);
        }
    }
}
