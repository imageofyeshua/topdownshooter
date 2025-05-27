using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Input.Touch;
using Microsoft.Xna.Framework.Media;

namespace TopDownShooter;

public class mKeyboard
{
    public KeyboardState newKeyboard, oldKeyboard;
    public List<mKey> pressedKeys = new List<mKey>(), previousPressedKeys = new List<mKey>();
    public mKeyboard()
    {

    }

    public virtual void Update()
    {
        newKeyboard = Keyboard.GetState();
        GetPressedKeys();
    }

    public void UpdateOld()
    {
        oldKeyboard = newKeyboard;

        previousPressedKeys = new List<mKey>();
        for (int i = 0; i < pressedKeys.Count; i++)
        {
            previousPressedKeys.Add(pressedKeys[i]);
        }
    }

    public bool GetPress(string Key)
    {
        for (int i = 0; i < pressedKeys.Count; i++)
        {
            if (pressedKeys[i].key == Key)
            {
                return true;
            }
        }

        return false;
    }

    public virtual void GetPressedKeys()
    {
        bool found = false;

        pressedKeys.Clear();
        for (int i = 0; i < newKeyboard.GetPressedKeys().Length; i++)
        {
            pressedKeys.Add(new mKey(newKeyboard.GetPressedKeys()[i].ToString(), 1));
        }
    }
}