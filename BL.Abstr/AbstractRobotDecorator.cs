

using System;
using System.Collections.Generic;

namespace BL.Abstr
{
    public abstract class AbstractRobotDecorator : Robot
    {
        protected Robot robot;
        public AbstractRobotDecorator() : base() { }
        public void SetRobot(Robot robot)
        {
            this.robot = robot;
            this.PlayerId = robot.PlayerId;
        }
        public override Type GetCompilerTimeType()
        {
            return robot.GetCompilerTimeType();
        }
        public override int GetPosX { get => this.robot.GetPosX; set => this.robot.GetPosX = value; }
        public override int GetPosY { get => this.robot.GetPosY; set => this.robot.GetPosY = value; }
        public override int Battery { get => this.robot.Battery; set => this.robot.Battery = value; }
        public override List<AbstractCargo> Backpack { get => this.robot.Backpack; }
        public override void ReduceBattery(int reducer)
        {
            this.robot.ReduceBattery(reducer);
        }
        public override void ActionMoveDown()
        {
            this.robot.ActionMoveDown();
        }
        public override void ActionMoveUp()
        {
            this.robot.ActionMoveUp();
        }
        public override void ActionMoveRight()
        {
            this.robot.ActionMoveRight();
        }
        public override void ActionMoveLeft()
        {
            this.robot.ActionMoveLeft();
        }
        public override void PickupCargo(AbstractCargo cargo)
        {
            this.robot.PickupCargo(cargo);
        }
    }
}
