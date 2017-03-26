using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GameJam
{
    public partial class GameForm : Form
    {
        public Keys KeyPressed { get; private set; }

        public GameForm()
        {
            InitializeComponent();

            KeyDown += GameForm_KeyDown;
            KeyUp += GameForm_KeyUp;

            var game = new Game(this);
            game.Start();
        }

        private void GameForm_KeyUp(object sender, KeyEventArgs e)
        {
            KeyPressed = Keys.None;
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            KeyPressed = e.KeyCode;
        }


        public void DrawTo(Level level)
        {
            var image = new Bitmap(screen.Width, screen.Height);
            var g = Graphics.FromImage(image);

            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillRectangle(Brushes.CadetBlue, ClientRectangle);

            if (level == null) return;
            var matrix = g.Transform;

            foreach (var unit in level.Units)
            {
                g.Transform = matrix;
                var sprite = unit.GetSprite();
                g.TranslateTransform((float)unit.Location.X, (float)unit.Location.Y);
                g.DrawImage(sprite, new Point(-sprite.Width / 2, -sprite.Height / 2));
            }
            screen.Image = image;
        }
    }
}