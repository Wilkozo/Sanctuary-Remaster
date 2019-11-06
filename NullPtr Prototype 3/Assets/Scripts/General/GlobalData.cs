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
    private static int currentNumOfActions;
    private static int baseNumOfActions = 6; // Prevents setting to another value
    private static bool isTired;
    private static bool isVeryTired;
    private static bool isWellRested;
    private static bool isInMessage;

    public static int InAction
    {
        get
        {
            return baseNumOfActions;
        }
        set
        {
            baseNumOfActions = 6;
        }
    }

    public static bool GetSetVeryTired
    {
        get
        {
            return isVeryTired;
        }
        set
        {
            isVeryTired = value;
        }
    }

    public static bool InMessage
    {
        get
        {
            return isInMessage;
        }
        set
        {
            isInMessage = value;
        }
    } // Needed to prevent action ending scene auto to change scenes. 

    public static int GetSetCurrentActions
    {
        get
        {
            return currentNumOfActions;
        }
        set
        {
            currentNumOfActions = value;
        }
    }

    public static bool GetSetTired
    {
        get
        {
            return isTired;
        }
        set
        {
            isTired = value;
        }
    }

    public static bool GetSetWellRested
    {
        get
        {
            return isWellRested;
        }
        set
        {
            isWellRested = value;
        }
    }

    public static int TimeOfDay
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