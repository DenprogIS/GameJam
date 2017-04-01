using System.Drawing;

namespace GameJam
{
    public class Coordinates
    {
        private Size Size;

        private Vector leftTop { get; set; }
        private Vector rightTop { get; set; }
        private Vector leftBottom { get; set; }
        private Vector rightBottom { get; set; }

        public Vector LeftTop
        {
            get { return leftTop; }
            set
            {
                leftTop = value;
                rightTop = new Vector(leftTop.X + Size.Width, leftTop.Y);
                leftBottom = new Vector(leftTop.X, leftTop.Y + Size.Height);
                rightBottom = new Vector(leftTop.X + Size.Width, leftTop.Y + Size.Height);
            }
        }

        public Vector RightTop
        {
            get { return rightTop; }
            set
            {
                rightTop = value;
                leftTop = new Vector(rightTop.X - Size.Width, rightTop.Y);
                leftBottom = new Vector(leftTop.X, leftTop.Y + Size.Height);
                rightBottom = new Vector(leftTop.X + Size.Width, leftTop.Y + Size.Height);
            }
        }

        public Vector LeftBottom
        {
            get { return leftBottom; }
            set
            {
                leftBottom = value;
                leftTop = new Vector(leftBottom.X, leftBottom.Y - Size.Height);
                rightTop = new Vector(leftTop.X + Size.Width, leftTop.Y);
                rightBottom = new Vector(leftTop.X + Size.Width, leftTop.Y + Size.Height);
            }
        }

        public Vector RightBottom
        {
            get { return rightBottom; }
            set
            {
                rightBottom = value;
                leftTop = new Vector(rightBottom.X - Size.Width, rightBottom.Y - Size.Height);
                rightTop = new Vector(leftTop.X + Size.Width, leftTop.Y);
                leftBottom = new Vector(leftTop.X, leftTop.Y + Size.Height);
            }
        }

        public Coordinates(Vector location, Size size)
        {
            LeftTop = new Vector(location.X, location.Y);
            Size = size;
        }
    }
}
