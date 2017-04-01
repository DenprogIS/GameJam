using System;
using System.Drawing;
namespace GameJam
{
    class Player : IUnit
    {
        public Box Box { get; }

        public Player(Vector startLocation)
        {
            Box = new Box(startLocation, GetSprite().Size, maxHorizontalVelocity:1);
        }

        public Action Act()
        {
            return Action.GoRight;
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
