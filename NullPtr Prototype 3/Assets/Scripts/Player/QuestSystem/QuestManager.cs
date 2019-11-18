﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QuestSystem;
public class QuestManager : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        int i = 0;
        foreach(Quest it in QuestHolder.CurrentQuests )
        {
            if(it.IsComplete() == true)
            {
                Reward(it.questIdentifier._questID);
                QuestHolder.AddQuestToDone(it);
                QuestHolder.RemoveQuestFromCurrent(i);
                i--;
            }
            i++;
        }
    }

    public void CollectionCheck(GameObject item)
    {
        foreach (Quest it in QuestHolder.CurrentQuests)
        {
            it.CheckCollection(item);
        }
    }

    void Reward(int ID)
    {
        Debug.Log(PlayerStats.Hope);
        switch(ID)
        {
            case 1:
                {
                    PlayerStats.Hope += 5;
                    break;
                }
        }
        Debug.Log("Rewarded");
        Debug.Log(PlayerStats.Hope);

    }
}
