using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bread : MonoBehaviour
{
    BoxCollider boxCollider;
    // Start is called before the first frame update
    void Start()
    {
        if (QuestHolder.isQuestAlreadyFinished(1))
        {
            Destroy(this);
            return;
        }
        boxCollider = GetComponent<BoxCollider>();
        boxCollider.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(QuestHolder.isQuestAlreadyGiven(1))
        {
            boxCollider.enabled = true;
        }
    }
}
