using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;

namespace TopDownShooter;

public class mTimer
{
    public bool goodToGo;
    protected int mSec;
    protected TimeSpan timer = new TimeSpan();

    public mTimer(int m)
    {
        goodToGo = false;
        mSec = m;
    }
    public mTimer(int m, bool startLoaded)
    {
        goodToGo = startLoaded;
        mSec = m;
    }

    public int MSec
    {
        get { return mSec; }
        set { mSec = value; }
    }
    public int Timer
    {
        get { return (int)timer.TotalMilliseconds; }
    }

    public void UpdateTimer()
    {
        timer += Globals.gameTime.ElapsedGameTime;
    }

    public void UpdateTimer(float Speed)
    {
        timer += TimeSpan.FromTicks((long)(Globals.gameTime.ElapsedGameTime.Ticks * Speed));
    }

    public virtual void AddToTimer(int mSec)
    {
        timer += TimeSpan.FromMilliseconds((long)(mSec));
    }

    public bool Test()
    {
        if (timer.TotalMilliseconds >= mSec || goodToGo)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Reset()
    {
        timer = timer.Subtract(new TimeSpan(0, 0, mSec / 60000, mSec / 1000, mSec % 1000));
        if (timer.TotalMilliseconds < 0)
        {
            timer = TimeSpan.Zero;
        }
        goodToGo = false;
    }

    public void Reset(int newTimer)
    {
        timer = TimeSpan.Zero;
        MSec = newTimer;
        goodToGo = false;
    }

    public void ResetToZero()
    {
        timer = TimeSpan.Zero;
        goodToGo = false;
    }

    public virtual XElement ReturnXML()
    {
        XElement xml = new XElement("Timer",
                                new XElement("mSec", mSec),
                                new XElement("timer", Timer));

        return xml;
    }

    public void SetTimer(TimeSpan Time)
    {
        timer = Time;
    }

    public virtual void SetTimer(int mSec)
    {
        timer = TimeSpan.FromMilliseconds((long)(mSec));
    }
}