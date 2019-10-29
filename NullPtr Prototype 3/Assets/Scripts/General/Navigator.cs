using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigator : MonoBehaviour {

    [SerializeField] private GameObject button;
    public bool isActive;
    public bool isDisabling;
    public bool iniEnable;
    public bool inRange;
    private float age;

	// Use this for initialization
	void Start ()
    {
        isDisabling = true;
        isActive = false;
        iniEnable = false;
        age = 0f;
	}
	
	// Update is called once per frame
	void Update ()
    {
        age += Time.deltaTime;

        if (age > 1.51 && !iniEnable)
        {
            isActive = true;
            iniEnable = true;
        }

        if (isActive)
        {
            button.SetActive(inRange);
        }
        else if (isDisabling)
        {
            button.SetActive(false);
        }

	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            inRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            inRange = false;
        }
    }
}
