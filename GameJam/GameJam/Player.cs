using System;
using System.Collections.Generic;
using System.Drawing;
namespace GameJam
{
    class Player : IUnit
    {
        public Box Box { get; }

        public Player(Vector startLocation)
        {
            Box = new Box(startLocation, GetSprite().Size);
        }

        public Action Act()
        {
            throw new NotImplementedException();
        }

        public bool DeadInConflict(IUnit other)
        {
            throw new NotImplementedException();
        }

        public Image GetSprite()
        {
            return Image.FromFile("Resources/sprite.png"); 
        }
    }
}
