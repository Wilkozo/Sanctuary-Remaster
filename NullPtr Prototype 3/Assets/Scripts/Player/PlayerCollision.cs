using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QuestSystem;
public class PlayerCollision : MonoBehaviour
{
    QuestManager questManager;
    private void Start()
    {
        questManager = FindObjectOfType<QuestManager>();
    }
    private void OnTriggerEnter(Collider collider)
    {
        questManager.CollectionCheck(collider.gameObject);
        if(collider.tag == "Bread")
        {
            Destroy(collider.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        questManager.CollectionCheck(collider.gameObject);
    }
}
