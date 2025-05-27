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
    public float speed;

    public Unit(string Path, Vector2 Pos, Vector2 Dims) : base(Path, Pos, Dims)
    {
        speed = 2.0f;
    }

    public override void Update()
    {

    }

    public override void Draw(Vector2 Offset)
    {
        base.Draw(Offset);
    }
}