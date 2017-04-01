using System.Drawing;

namespace GameJam
{
    public interface IUnit
    {
        Box Box { get;}
        Action Act();
        bool DeadInConflict(IUnit other);
        Image GetSprite();
    }
}
