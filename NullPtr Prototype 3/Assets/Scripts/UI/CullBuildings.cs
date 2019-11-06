using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CullBuildings : MonoBehaviour
{
    private Color r;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "CullBuilding") {
            other.gameObject.GetComponent<MeshRenderer>().material.color = new Color(1,1,1,0.5f);
           //r.a = 0.0f;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        other.gameObject.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1, 1.0f);
        //other.gameObject.GetComponent<MeshRenderer>().enabled = true;
    }



}
