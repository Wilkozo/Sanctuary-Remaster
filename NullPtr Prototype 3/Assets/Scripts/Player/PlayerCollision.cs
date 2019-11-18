using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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
