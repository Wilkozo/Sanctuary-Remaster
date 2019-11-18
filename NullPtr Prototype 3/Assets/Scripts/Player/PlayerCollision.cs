using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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
