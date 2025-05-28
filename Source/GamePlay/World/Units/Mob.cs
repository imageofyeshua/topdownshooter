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

public class Mob : Unit
{
    public Mob(string Path, Vector2 Pos, Vector2 Dims) : base(Path, Pos, Dims)
    {
        speed = 2.0f;
    }

    public virtual void Update(Vector2 Offset, Tank tank)
    {
        AI(tank);
        base.Update(Offset);
    }

    public virtual void AI(Tank tank)
    {
        pos += Globals.RadialMovement(tank.pos, pos, speed);
        rot = Globals.RotateTowards(pos, tank.pos);
    }

    public override void Draw(Vector2 Offset)
    {
        base.Draw(Offset);
    }
}