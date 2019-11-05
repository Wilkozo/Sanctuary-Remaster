using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CullBuildings : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "CullBuilding") {
            other.gameObject.GetComponent<MeshRenderer>().enabled = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        other.gameObject.GetComponent<MeshRenderer>().enabled = true;
    }



}
