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

public class Bullet : Projectile2D
{
    public Bullet(Vector2 Pos, Unit Owner, Vector2 Target)
        : base("2D/Projectiles/bullet", Pos, new Vector2(20, 20), Owner, Target)
    {
    }

    public override void Update(Vector2 Offset, List<Unit> Units)
    {
        base.Update(Offset, Units);
    }

    public override void Draw(Vector2 Offset)
    {
        base.Draw(Offset);
    }
}