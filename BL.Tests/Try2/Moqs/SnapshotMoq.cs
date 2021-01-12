using BL.Abstr;
using BL.Impl;

namespace BL.Tests.Try2.Moqs
{
    public class SnapshotMoq : FieldSnapshot
    {
        public SnapshotMoq(IGameObject[,] fieldarr, Robot robot, IField field) : base(fieldarr, robot, field) { }
        public SnapshotMoq() : base() { }
        public void SetFieldArr(IGameObject[,] arr)
        {
            this.fieldarr = arr;
        }
        public void SetField(IField field)
        {
            this.field = field;
        }
        public void SetRobot(Robot robot)
        {
            this.robot = robot;
        }

    }
}
