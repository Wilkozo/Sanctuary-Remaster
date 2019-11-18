using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QuestSystem;
//Holds all the quest done and current quests
public static class QuestHolder
{
    public static List<Quest> CurrentQuests = new List<Quest>();
    public static List<Quest> DoneQuests = new List<Quest>();

    public static void AddQuestToCurrent(Quest newQuest)
    {
        if(isQuestAlreadyGiven(newQuest.questIdentifier._questID))
        CurrentQuests.Add(newQuest);
    }
    public static void AddQuestToDone(Quest newQuest)
    {
        DoneQuests.Add(newQuest);
    }
    public static void RemoveQuestFromCurrent(int index)
    {
        CurrentQuests.RemoveAt(index);
    }
    public static void RemoveQuestFromDone(int index) // Not really needed
    {
        DoneQuests.RemoveAt(index);
    }
    public static bool isQuestAlreadyGiven(int ID)
    {
        foreach (Quest it in CurrentQuests)
        {
            if(ID == it.questIdentifier._questID)
            {
                return true;
            }
        }
        foreach (Quest it in DoneQuests)
        {
            if(ID == it.questIdentifier._questID)
            {
                return true;
            }
        }
        return false;
    }
    // Update is called once per frame
}
