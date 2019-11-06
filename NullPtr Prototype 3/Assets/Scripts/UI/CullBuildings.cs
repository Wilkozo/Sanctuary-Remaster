using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CullBuildings : MonoBehaviour
{

    public GameObject[] buildings;

    private void Start()
    {
        buildings = GameObject.FindGameObjectsWithTag("CullBuilding");
        foreach (GameObject building in buildings) {
            building.GetComponent<MeshRenderer>().material.SetOverrideTag("RenderType", "Opaque");
                //color = new Color(1, 1, 1, 0.99f);
        }     
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "CullBuilding") {
            other.GetComponent<MeshRenderer>().material.SetOverrideTag("RenderType", "TransparentFade");
            other.gameObject.GetComponent<MeshRenderer>().material.color = new Color(1,1,1,0.5f);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<MeshRenderer>().material.SetOverrideTag("RenderType", "");
        other.gameObject.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1, 1.0f);
    }



}
