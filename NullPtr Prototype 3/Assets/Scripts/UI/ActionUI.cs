using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionUI : MonoBehaviour
{

    public List<GameObject> actionPoints;
    public GameObject[] ap;



    // Start is called before the first frame update
    void Start()
    {

        DontDestroyOnLoad(this.gameObject);

        ap = GameObject.FindGameObjectsWithTag("AP");

        Debug.Log(GlobalData.GetSetCurrentActions);

        //check to see if the value of current actions != the length of the list
        if (GlobalData.GetSetCurrentActions < ap.Length)
        {
            for (int i = ap.Length; i > GlobalData.GetSetCurrentActions; i--)
            {
                GameObject lastItem = ap[ap.Length - i];
                lastItem.SetActive(false);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(GlobalData.GetSetCurrentActions);

        if (GlobalData.GetSetCurrentActions < ap.Length)
        {
            for (int i = ap.Length; i > GlobalData.GetSetCurrentActions; i--)
            {
                GameObject lastItem = ap[ap.Length - i];
                lastItem.SetActive(false);
            }
        }
    }
}
