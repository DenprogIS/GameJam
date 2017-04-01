using System;
using System.Collections.Generic;

namespace GameJam
{
    public class Physics
    {
        private Vector gravity;

        public Physics(Vector gravity)
        {
            this.gravity = gravity;
        }

        public void Move(List<IUnit> units)
        {
            foreach (var unit in units)
            {
                StabilizeByFormSize(unit);
                unit.Box.Move();
            }

            SetNewVelocity(units);
        }

        private void SetNewVelocity(List<IUnit> units)
        {
            foreach (var unit in units)
            {
                var unitForce = GetForceByAction(unit.Act());
                unit.Box.Velocity += unitForce + gravity;
                
                if (unit.Box.Velocity.X > unit.Box.MaxHorizontalVelocity)
                    unit.Box.Velocity = new Vector(unit.Box.MaxHorizontalVelocity, unit.Box.Velocity.Y);

                //if (unit.Box.Velocity) //TODO
            }
        }

        private Vector GetForceByAction(Action action)
        {
            switch (action)
            {
                    case Action.GoLeft: return new Vector(-1,0);
                    case Action.GoRight: return new Vector(1,0);
                    case Action.Jump: return new Vector(0, -1);
                    case Action.None: return new Vector(0,0);
                default: throw new NotImplementedException();
            }
        }

        private void StabilizeByFormSize(IUnit unit)
        {
            var unitPosition = unit.Box.Coordinates;
            var unitVelocity = unit.Box.Velocity;

            var compressionRatioX = 1d;
            var compressionRatioY = 1d;

            if (unitPosition.RightTop.X + unitVelocity.X > GameForm.FormSize.Width)
                compressionRatioX = (GameForm.FormSize.Width - unitPosition.RightTop.X)/unitVelocity.X;
            else if (unitPosition.LeftTop.X + unitVelocity.X < 0)
                compressionRatioX = unitPosition.LeftTop.X / unitVelocity.X;

            if (unitPosition.LeftBottom.Y + unitVelocity.Y > GameForm.FormSize.Height)
                compressionRatioY = (GameForm.FormSize.Height - unitPosition.LeftBottom.Y) / unitVelocity.Y;
            else if (unitPosition.LeftTop.Y + unitVelocity.Y < 0)
                compressionRatioY = unitPosition.LeftBottom.Y / unitVelocity.Y;

            unit.Box.Velocity = new Vector(unitVelocity.X * compressionRatioX, unitVelocity.Y * compressionRatioY);
        }

        public bool Kill()
        {
            return true;
        }
    }
}
