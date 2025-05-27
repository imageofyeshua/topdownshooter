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

public class Projectile2D : Basic2D
{
    public bool done;

    public float speed;

    public Vector2 direction;

    public Unit owner;

    public mTimer timer;

    public Projectile2D(string Path, Vector2 Pos, Vector2 Dims, Unit Owner, Vector2 Target)
        : base(Path, Pos, Dims)
    {
        done = false;
        speed = 5.0f;
        owner = Owner;
        direction = Target - owner.pos;
        direction.Normalize();

        rot = Globals.RotateTowards(pos, new Vector2(Target.X, Target.Y));

        timer = new mTimer(2400);
    }

    public virtual void Update(Vector2 Offset, List<Unit> Units)
    {
        pos += direction * speed;

        timer.UpdateTimer();

        if (timer.Test())
        {
            done = true;
        }

        if (HitSomething(Units))
        {
            done = true;
        }
    }

    public virtual bool HitSomething(List<Unit> Units)
    {
        return false;
    }

    public override void Draw(Vector2 Offset)
    {
        base.Draw(Offset);
    }
}