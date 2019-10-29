using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Friend : MonoBehaviour {

    public GameObject talkButton;
    public int hopeThreshold;
    public GameObject playerSprite;
    public bool isInRange;
    private SpriteRenderer sprite;
    private float bobOffset;
    public bool playerSpriteIsActive = false;
    public GameObject talkPanel;
    bool hasClicked = false;

    // Use this for initialization
    void Start ()
    {
        if (hopeThreshold <= PlayerStats.Hope)
        {
            playerSpriteIsActive = true;
        }
        else
        {
            playerSpriteIsActive = false;
        }

        playerSprite.SetActive(playerSpriteIsActive);
        
        // Offset bob animation
        bobOffset = Random.Range(0.0f, 1.0f);

    }
	
	void Update ()
    {

        // player bobbing
        float offset = Random.Range(0.0f, 1.0f);
        playerSprite.transform.localPosition = new Vector3(0, Mathf.Sin((bobOffset + Time.time) * 3) * 0.05f, 0);
    }

    public void Talk()
    {
        
        //if (hasClicked == false)
        //{
            FindObjectOfType<AudioManager>().Play("Click");
        //   hasClicked = true;
        //}
        talkPanel.SetActive(true);
        FindObjectOfType<TalkHandler>().reRoll = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            isInRange = true;
            if (playerSpriteIsActive)
            {
                talkButton.SetActive(true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            isInRange = false;
            talkButton.SetActive(false);
            talkPanel.SetActive(false);
        }
    }
}
