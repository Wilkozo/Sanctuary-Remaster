using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pastor : MonoBehaviour
{
    [SerializeField] PastorDialogue dialogue;


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
        if (NPCPastor.Hope < 0)
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
        GlobalData.talkedToPastor = true;

        switch (NPCPastor.Hope)
        {
            case 10:
                NPCPastor.Hope -= 10;
                break;
            case 20:
                NPCPastor.Hope -= 10;
                break;
            case 30:
                NPCPastor.Hope -= 10;
                break;
            case 40:
                NPCPastor.Hope -= 10;
                break;
            case 50:
                NPCPastor.Hope -= 40;
                break;
            case 60:
                NPCPastor.Hope -= 40;
                break;
            case 70:
                NPCPastor.Hope -= 40;
                break;
            case 80:
                NPCPastor.Hope -= 40;
                break;
            case 0:
                NPCPastor.Hope += 70;
                break;
        }

        talkPanel.SetActive(false);
    }

    public void disagree()
    {

        GlobalData.GetSetCurrentActions -= 1;
        GlobalData.talkedToPastor = true;

        switch (NPCPastor.Hope)
        {
            case 10:
                NPCPastor.Hope += 10;
                break;
            case 20:
                NPCPastor.Hope += 40;
                break;
            case 30:
                NPCPastor.Hope += 30;
                break;
            case 40:
                NPCPastor.Hope += 40;
                break;
            case 50:
                NPCPastor.Hope += 10;
                break;
            case 60:
                NPCPastor.Hope += 10;
                break;
            case 70:
                NPCPastor.Hope += 10;
                break;
            case 80:
                NPCPastor.Hope += 10;
                break;
            case 0:
                NPCPastor.Hope += 20;
                break;
        }

        talkPanel.SetActive(false);
    }

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            inRange = true;
            if (playerSpriteIsActive && GlobalData.talkedToPastor == false)
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
            if (playerSpriteIsActive && GlobalData.talkedToPastor == false)
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
