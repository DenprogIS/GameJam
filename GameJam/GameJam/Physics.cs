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
            }
        }

        private void StabilizeByFormSize(IUnit unit)
        {
            
        }

        public bool Kill()
        {
            throw new NotImplementedException();
        }
    }
}
