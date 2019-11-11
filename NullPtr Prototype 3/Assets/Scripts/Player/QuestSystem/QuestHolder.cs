using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QuestSystem;
//Holds all the quest done and current quests
public static class QuestHolder
{
    public static List<Quest> CurrentQuests;
    public static List<Quest> DoneQuest;

    public static void AddQuestToCurrent(Quest newQuest)
    {
        CurrentQuests.Add(newQuest);
    }
    public static void AddQuestToDone(Quest newQuest)
    {
        DoneQuest.Add(newQuest);
    }
    // Update is called once per frame
}
