using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QuestSystem;
public class QuestDisplay : MonoBehaviour
{
    [SerializeField] bool showQuests;

    void ShowQuests()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        showQuests = false;
    }

    // Update is called once per frame
    void Update()
    {
        string bigString;
        foreach (Quest it  in QuestHolder.CurrentQuests)
        {
            bigString = it.GetString();
        }
    }
}
