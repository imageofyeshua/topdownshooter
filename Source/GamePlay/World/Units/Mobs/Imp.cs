using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Content;
using System.Collections;

namespace TopDownShooter;

public class Imp : Mob
{
    public Imp(Vector2 Pos)
        : base("2D/Units/Mobs/demon", Pos, new Vector2(40, 40))
    {
        speed = 2.0f;
    }

    public override void Update(Vector2 Offset, Tank tank)
    {
        base.Update(Offset, tank);
    }

    public override void Draw(Vector2 Offset)
    {
        base.Draw(Offset);
    }
}