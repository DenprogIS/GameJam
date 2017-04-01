using System.Collections.Generic;

namespace GameJam
{
    class LevelGenerator
    {
        public static Queue<Level> GetLevels()
        {
            //TODO
            var result = new Queue<Level>();

            var startLocation = new Vector(0, 0);
            var gravity = new Vector(0,1);
            var physics = new Physics(gravity);
            var firstLevel = new Level(new List<IUnit>() {new Player(startLocation)}, physics);
            result.Enqueue(firstLevel);

            return result;
        }
    }
}
