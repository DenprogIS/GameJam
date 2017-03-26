using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam
{
    class Player : IUnit
    {
        public Vector Location { get; set; }

        public Player(Vector startLocation)
        {
            Location = startLocation;
        }

        public Image GetSprite()
        {
            return Image.FromFile("Resources/sprite.png"); ;
        }

        public void Act()
        {
            throw new NotImplementedException();
        }
    }
}
