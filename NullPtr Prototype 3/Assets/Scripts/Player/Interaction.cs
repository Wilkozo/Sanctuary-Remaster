using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public LayerMask selectionMask;
    [SerializeField] private int maxDistance;

    Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit, maxDistance, selectionMask))
            {
                Debug.Log("Hit " + hit.collider.name + " " + hit.point);
                //All Selection stuff goes here
                //This would include movement
            }
        }
    }
}
