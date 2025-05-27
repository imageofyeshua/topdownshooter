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
    public Tank tank;

    public World()
    {
        tank = new Tank("2D/tank", new Vector2(300, 200), new Vector2(48, 48));
    }

    public virtual void Update()
    {
        tank.Update();
    }

    public virtual void Draw()
    {
        tank.Draw();
    }
}