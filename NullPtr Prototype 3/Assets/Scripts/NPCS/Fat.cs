using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fat : MonoBehaviour
{
    [SerializeField] FatDialogue dialogue;


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
        talkPanel.SetActive(false);

    }

    void Update()
    {
        //bobbing
        float offset = Random.Range(0.0f, 1.0f);

        sprite.transform.localPosition = new Vector3(0, Mathf.Sin((bobOffset + Time.time) * 3) * 0.05f, 0);

        //checks to see if the npc has lost hope
        if (NPCFat.Hope < 0)
        {
            playerSpriteIsActive = false;
        }
    }

    //changes the text based on the day 
    public void dayNumber()
    {
        dialogue.dayDialogue();
    }

    public void talk()
    {

        talkButton.SetActive(false);
        //plays audio
        FindObjectOfType<AudioManager>().Play("Click");
        //enable the buttons and text
        talkPanel.SetActive(true);

        dialogue.dayDialogue();

    }

    public void agree()
    {

        GlobalData.GetSetCurrentActions -= 1;
        GlobalData.talkedToFat = true;

        switch (NPCFat.Hope)
        {
            case 10:
                NPCFat.Hope -= 10;
                break;
            case 20:
                NPCFat.Hope -= 10;
                break;
            case 30:
                NPCFat.Hope -= 10;
                break;
            case 40:
                NPCFat.Hope -= 10;
                break;
            case 50:
                NPCFat.Hope -= 30;
                break;
            case 60:
                NPCFat.Hope += 10;
                break;
            case 70:
                NPCFat.Hope += 10;
                break;
            case 80:
                NPCFat.Hope -= 40;
                break;
            case 0:
                NPCFat.Hope += 20;
                break;
        }

        talkPanel.SetActive(false);
    }

    public void disagree()
    {

        GlobalData.GetSetCurrentActions -= 1;
        GlobalData.talkedToFat = true;

        switch (NPCFat.Hope)
        {
            case 10:
                NPCFat.Hope += 40;
                break;
            case 20:
                NPCFat.Hope += 40;
                break;
            case 30:
                NPCFat.Hope += 40;
                break;
            case 40:
                NPCFat.Hope += 40;
                break;
            case 50:
                NPCFat.Hope += 10;
                break;
            case 60:
                NPCFat.Hope -= 40;
                break;
            case 70:
                NPCFat.Hope -= 40;
                break;
            case 80:
                NPCFat.Hope += 10;
                break;
            case 0:
                NPCFat.Hope += 70;
                break;
        }

        talkPanel.SetActive(false);
    }

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            inRange = true;
            if (playerSpriteIsActive && GlobalData.talkedToFat == false)
            {
                talkButton.SetActive(true);
            }
        }
    }

    public void OnTriggerExit(Collider collision)
    {
        if (collision.tag == "Player")
        {
            inRange = false;
            talkButton.SetActive(false);
            talkPanel.SetActive(false);
        }
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            inRange = true;
            if (playerSpriteIsActive && GlobalData.talkedToFat == false)
            {
                talkButton.SetActive(true);
            }
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            inRange = false;
            talkButton.SetActive(false);
            talkPanel.SetActive(false);
        }
    }

}
