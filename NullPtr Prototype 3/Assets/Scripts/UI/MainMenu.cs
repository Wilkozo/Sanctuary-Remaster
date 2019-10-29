using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject logo;
    [SerializeField] private GameObject menus;
    [SerializeField] private GameObject credits;

    public bool showCredits;

	// Use this for initialization
	void Start ()
    {
        showCredits = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void ShowCredits()
    {
        showCredits = !showCredits;
        menus.SetActive(!showCredits);
        credits.SetActive(showCredits);
    }
}
