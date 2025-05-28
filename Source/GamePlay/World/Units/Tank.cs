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

public class Tank : Unit
{
    public Tank(string Path, Vector2 Pos, Vector2 Dims) : base(Path, Pos, Dims)
    {
        speed = 2.0f;
    }

    public override void Update(Vector2 Offset)
    {
        if (Globals.keyboard.GetPress("A"))
        {
            pos = new Vector2(pos.X - speed, pos.Y);
        }
        if (Globals.keyboard.GetPress("D"))
        {
            pos = new Vector2(pos.X + speed, pos.Y);
        }
        if (Globals.keyboard.GetPress("W"))
        {
            pos = new Vector2(pos.X, pos.Y - speed);
        }
        if (Globals.keyboard.GetPress("S"))
        {
            pos = new Vector2(pos.X, pos.Y + speed);
        }

        rot = Globals.RotateTowards(pos, new Vector2(Globals.mouse.newMousePos.X, Globals.mouse.newMousePos.Y));

        if (Globals.mouse.LeftClick())
        {
            GameGlobals.PassProjectile(new Bullet(new Vector2(pos.X, pos.Y), this, new Vector2(Globals.mouse.newMousePos.X, Globals.mouse.newMousePos.Y)));
        }

        base.Update(Offset);
    }

    public override void Draw(Vector2 Offset)
    {
        base.Draw(Offset);
    }
}