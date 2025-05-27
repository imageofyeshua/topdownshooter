using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace TopDownShooter;

public class Globals
{
    public static int screenHeight, screenWidth;

    public static ContentManager content;
    public static SpriteBatch spriteBatch;

    public static mKeyboard keyboard;
    public static mMouseControl mouse;

    public static float GetDistance(Vector2 pos, Vector2 target)
    {
        return (float)Math.Sqrt(Math.Pow(pos.X - target.X, 2) + Math.Pow(pos.Y - target.Y, 2));
    }

    public static float RotateTowards(Vector2 Pos, Vector2 focus)
    {
        return (float)Math.Atan2(Pos.Y - focus.Y, Pos.X - focus.X) - MathHelper.PiOver2;
    }
}