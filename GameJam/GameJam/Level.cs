using System.Collections.Generic;

namespace GameJam
{
    public class Level
    {
        public List<IUnit> Units { get; }
        public Physics Physics { get; }

        public Level(List<IUnit> units, Physics physics)
        {
            Physics = physics;
            Units = units;
        }
    }
}
