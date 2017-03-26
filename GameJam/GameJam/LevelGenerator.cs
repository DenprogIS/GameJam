using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam
{
    class LevelGenerator
    {
        public static Queue<Level> GetLevels()
        {
            //TODO
            var result = new Queue<Level>();
            result.Enqueue(new Level(new List<IUnit> {new Player(new Vector(100,100)), new Player(new Vector(200, 100)) }));
            return result;
        }
    }
}
