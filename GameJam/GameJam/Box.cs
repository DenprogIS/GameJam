using System.Drawing;

namespace GameJam
{
    public class Box
    {
        public Vector Velocity { get; set; } = new Vector(0,0);
        public Coordinates Coordinates { get; set; }
        public bool ShouldDie { get; set; }

        public Box(Vector startLocation, Size size)
        {
            Coordinates = new Coordinates(startLocation, size);
        }
    }
}
