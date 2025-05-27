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

public class Basic2D
{
    public Vector2 pos, dims;
    public Texture2D myModel;

    public Basic2D(string Path, Vector2 Pos, Vector2 Dims)
    {
        pos = Pos;
        dims = Dims;

        myModel = Globals.content.Load<Texture2D>(Path);
    }

    public virtual void Update()
    {

    }

    public virtual void Draw()
    {
        if (myModel != null)
        {
            Globals.spriteBatch.Draw(myModel,
                new Rectangle((int)(pos.X), (int)(pos.Y), (int)dims.X, (int)dims.Y),
                null, Color.White, 0.0f,
                new Vector2(myModel.Bounds.Width / 2, myModel.Bounds.Height / 2),
                new SpriteEffects(), 0
            );
        }
    }
}