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

namespace TopDownShooter;

public class Unit : Basic2D
{
    public bool dead;
    public float speed, hitDist;

    public Unit(string Path, Vector2 Pos, Vector2 Dims) : base(Path, Pos, Dims)
    {
        dead = false;
        speed = 2.0f;

        hitDist = 35.0f;
    }

    public override void Update(Vector2 Offset)
    {
        base.Update(Offset);
    }

    public virtual void GetHit()
    {
        dead = true;
    }

    public override void Draw(Vector2 Offset)
    {
        base.Draw(Offset);
    }
}