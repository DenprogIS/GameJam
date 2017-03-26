using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam
{
    public interface IUnit
    {
        Vector Location { get; set; }
        Image GetSprite();
        void Act();
    }
}
