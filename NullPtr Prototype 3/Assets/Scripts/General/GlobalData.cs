using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GlobalData
{
    private static int timePoint = 0;
    private static int questionNumber;
    private static float startPosition = -3.48f;
    private static string lastScene = "HomeExt";
    private static bool dreamDefeated = false;
    private static int dayCount;

    
    public static int TimeOfDay //0 - 2
    {
        get
        {
            return timePoint;
        }
        set
        {
            timePoint = value;
        }
    }

    public static float StartPos 
        {
        get 
        {
            return startPosition;
        }
        set 
        {
            startPosition = value;
        }
    }

    public static string LastScene 
    {
        get 
        {
            return lastScene;
        }
        set 
        {
            lastScene = value;
        }
    }

    public static int Day
    {
        get
        {
            return dayCount;
        }
        set
        {
            dayCount = value;
        }
    }

    public static bool Victory 
    {
        get 
        {
            return dreamDefeated;
        }
        set 
        {
            dreamDefeated = value;
        }
    }
}