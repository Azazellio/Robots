using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using BL.Abstr;
using BL.Impl.RobotDecorators;
using BL.Impl.Robots;

namespace BL.Impl.Tests
{
    [TestFixture]
    public class RobotTest
    {

/*        [OneTimeSetUp]
        public void ClassInit()
        {

        }

        [SetUp]
        public void Init()
        {

        }*/
        
/*        [TestCase]
        public void RobotToxicDecoratorConstructor()
        {

        }*/
        
/*        public void SetPlayerId_Test()
        {
            var id = Guid.NewGuid();
            var id1 = Guid.NewGuid();
            var robot = new Cyborg();

            robot.SetPlayerId(id);
            Assert.AreEqual(robot.PlayerId, id1);
        }*/

        [TestCase(9, 9, 18)]
        public void CheckTest(int x, int y, int result)
        {
            var b = x + y;
            Assert.AreEqual(result, b);
        }
    }
}
