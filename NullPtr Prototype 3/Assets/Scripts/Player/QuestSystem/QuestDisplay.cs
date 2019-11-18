using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QuestSystem;
public class QuestDisplay : MonoBehaviour
{
    [SerializeField] private CanvasGroup canvasGroup;
    [SerializeField] bool showQuests;
    public bool openQuestWindow;
    [SerializeField] QuestLog questLog;


    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        showQuests = false;
        openQuestWindow = false;
        canvasGroup = GetComponent<CanvasGroup>();
    }

    // Update is called once per frame
    void Update()
    {
        if (openQuestWindow)
        {
            Open();
        }
        else
        {
            Close();
        }
        //string bigString;
        //foreach (Quest it in QuestHolder.CurrentQuests)
        //{
        //    bigString = it.GetString();
        //}
    }
    public void Switch()
    {
        openQuestWindow = !openQuestWindow;
    }
    public void Open()
    {
        canvasGroup.alpha = 1;
        canvasGroup.blocksRaycasts = true;
    }
    public void Close()
    {
        canvasGroup.alpha = 0;
        canvasGroup.blocksRaycasts = false;
    }
}
