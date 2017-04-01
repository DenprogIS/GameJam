using System.Drawing;

namespace GameJam
{
    public class Box
    {
        public Vector Velocity { get; set; } = new Vector(0,0);
        public Coordinates Coordinates { get; }
        public bool ShouldDie { get; set; }
        public double MaxHorizontalVelocity { get; }

        public Box(Vector startLocation, Size size, double maxHorizontalVelocity)
        {
            MaxHorizontalVelocity = maxHorizontalVelocity;
            Coordinates = new Coordinates(startLocation, size);
        }

        public void Move()
        {
            Coordinates.LeftTop += Velocity;
        }
    }
}
