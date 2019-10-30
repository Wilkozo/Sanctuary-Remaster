using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Artist : MonoBehaviour
{
    [SerializeField] ArtistDialogue dialogue;


    public GameObject talkButton;
    public GameObject sprite;
    public bool inRange;
    private SpriteRenderer npcSprite;
    private float bobOffset;
    public bool playerSpriteIsActive = true;
    public GameObject talkPanel;
    bool hasClicked = false;
   
    public bool badChoice = false;

    public int day = 1;

    void Start()
    {
        //bobbing
        bobOffset = Random.Range(0.0f, 1.0f);
        NPCArtistStats.Hope = 100;
    }

    void Update()
    {
        //bobbing
        float offset = Random.Range(0.0f, 1.0f);

        sprite.transform.localPosition = new Vector3(0, Mathf.Sin((bobOffset + Time.time) * 3) * 0.05f, 0);

        //checks to see if the npc has lost hope
        if (NPCArtistStats.Hope <= 0)
        {
            playerSpriteIsActive = false;
        }

    }

    //changes the text based on the day 
    public void dayNumber() {
        dialogue.dayDialogue(day);
    }

    public void talk() {

        //plays audio
        FindObjectOfType<AudioManager>().Play("Click");
        dayNumber();
        //enable the buttons and text
        talkPanel.SetActive(true);
    }

    public void agree() {
        Debug.Log("Agree");
        if (badChoice)
        {
            NPCArtistStats.Hope -= 10;
        }
        else if (!badChoice) {
            NPCArtistStats.Hope += 10;
        }
    }

    public void disagree() {
        Debug.Log("Disagree");

        if (!badChoice)
        {
            NPCArtistStats.Hope -= 10;
        }
        else if (badChoice) {
            NPCArtistStats.Hope += 10;
        }
    }


    public void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Player") {
            inRange = true;
            if (playerSpriteIsActive) {
                talkButton.SetActive(true);        
            }
        }
    }

    public void OnTriggerExit2D(Collider2D collision) {
        if (collision.tag == "Player") {
            inRange = false;
            talkButton.SetActive(false);
            talkPanel.SetActive(false);
        }
    }


}
