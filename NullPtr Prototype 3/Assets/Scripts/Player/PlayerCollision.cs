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
    private void OnCollisionEnter(Collision collision)
    {
        questManager.CollectionCheck(collision.gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        questManager.CollectionCheck(collision.gameObject);
    }
}
