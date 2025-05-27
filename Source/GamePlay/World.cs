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

public class World
{
    public Vector2 offset;

    public Tank tank;

    public List<Projectile2D> projectiles = new List<Projectile2D>();

    public World()
    {
        tank = new Tank("2D/tank", new Vector2(300, 200), new Vector2(48, 48));

        GameGlobals.PassProjectile = AddProjectile;

        offset = new Vector2(0, 0);
    }

    public virtual void Update()
    {
        tank.Update();

        for (int i = 0; i < projectiles.Count; i++)
        {
            projectiles[i].Update(offset, null);
            if (projectiles[i].done)
            {
                projectiles.RemoveAt(i);
                i--;
            }
        }
    }

    public virtual void AddProjectile(object Info)
    {
        projectiles.Add((Projectile2D)Info);
    }

    public virtual void Draw(Vector2 Offset)
    {
        tank.Draw(Offset);

        for (int i = 0; i < projectiles.Count; i++)
        {
            projectiles[i].Draw(offset);
        }
    }
}