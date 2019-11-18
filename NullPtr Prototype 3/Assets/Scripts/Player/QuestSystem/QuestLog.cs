using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QuestSystem;
using UnityEngine.UI;

public class QuestLog : MonoBehaviour
{
    [SerializeField]
    private GameObject questPrefab;
    private List<GameObject> questUIList = new List<GameObject>();
    [SerializeField] private Transform questList;
    private static QuestLog instance;
    private Quest selected;
    [SerializeField]
    private Text textDescription;

    public static QuestLog MyInstance
    {
        get
        {
            if(instance == null)
            {
                instance = GameObject.FindObjectOfType<QuestLog>();
                
            }
            return instance;
        }
    }
    void Start()
    {
        Quest newQuest = new Quest(new QuestIdentifier(1), new CollectionObjective("Collect the Bread", 10, "Collect", this.gameObject, "The Baker need help with his lost bread", false));
        QuestHolder.AddQuestToCurrent(newQuest);
        QuestLog.MyInstance.AddQuest(newQuest);
        foreach (Quest it in QuestHolder.CurrentQuests)
        {
            GameObject Temp = Instantiate(questPrefab, questList);
            QuestUI qs = Temp.GetComponent<QuestUI>();
            qs.quest = QuestHolder.CurrentQuests[QuestHolder.CurrentQuests.Count];
            qs.quest.questUI = qs;

            Temp.GetComponent<Text>().text = it.GetTitle(); // Makes the newQuest of the last quest within the list.
            questUIList.Add(Temp);
        }
    }

    void Update()
    {
        if (selected != null)
        {
            string title = selected.GetTitle();
            string description = selected.GetDescription();
            string myString = selected.GetUpdate();
            textDescription.text = string.Format("{0}\n<size=15>{1}</size>\nObjective\n<size=15>{2}</size>", title, description, myString);
        }

    }
    /// <summary>
    /// ALWAYS Add this last when making a new quest. Otherwise it will create for a new quest
    /// </summary>
    public void AddQuest(Quest quest)
    {
        GameObject Temp = Instantiate(questPrefab, questList);

        QuestUI qs = Temp.GetComponent<QuestUI>();
        qs.quest = quest;
        qs.quest.questUI = qs;
        Temp.GetComponent<Text>().text = quest.GetTitle(); // Makes the newQuest of the last quest within the list.
        questUIList.Add(Temp);
    }
    public void ShowDescription(Quest quest)
    {
        if(selected != null)
        {
            selected.questUI.DeSelect();
        }
        selected = quest;

        string title = quest.GetTitle();
        string description = quest.GetDescription();
        string myString = quest.GetUpdate();
        textDescription.text = string.Format("{0}\n<size=15>{1}</size>\nObjective\n<size=15>{2}</size>", title, description, myString);
    }
}
