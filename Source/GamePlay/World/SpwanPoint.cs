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

public class SpawnPoint : Basic2D
{
    public bool dead;
    public float hitDist;
    public mTimer spawnTimer = new mTimer(2200);

    public SpawnPoint(string Path, Vector2 Pos, Vector2 Dims) : base(Path, Pos, Dims)
    {
        dead = false;
        hitDist = 35.0f;
    }

    public override void Update(Vector2 Offset)
    {
        spawnTimer.UpdateTimer();

        if (spawnTimer.Test())
        {
            SpawnMob();
            spawnTimer.ResetToZero();
        }

        base.Update(Offset);
    }

    public virtual void GetHit()
    {
        dead = true;
    }

    public virtual void SpawnMob()
    {
        GameGlobals.PassMob(new Imp(new Vector2(pos.X, pos.Y)));
    }

    public override void Draw(Vector2 Offset)
    {
        base.Draw(Offset);
    }
}