using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using QuestSystem;
public class QuestUI : MonoBehaviour
{
    public Quest quest { get; set; }


    public void Select()
    {
        GetComponent<Text>().color = Color.red;
        QuestLog.MyInstance.ShowDescription(quest);
    }
    public void DeSelect()
    {
        GetComponent<Text>().color = Color.white;
    }
}
