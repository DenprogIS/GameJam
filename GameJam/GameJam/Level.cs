using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam
{
    public class Level
    {
        public List<IUnit> Units { get; }

        public Level(List<IUnit> units)
        {
            Units = units;
        }
    }
}
