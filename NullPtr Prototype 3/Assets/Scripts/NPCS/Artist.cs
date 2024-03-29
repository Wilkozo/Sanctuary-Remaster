﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using QuestSystem;

public class Artist : MonoBehaviour
{
    [SerializeField] ArtistDialogue dialogue;

    public GameObject bread;
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
        //NPCArtistStats.Hope = 35;
        talkPanel.SetActive(false);

    }

    void Update()
    {
        //bobbing
        float offset = Random.Range(0.0f, 1.0f);

        sprite.transform.localPosition = new Vector3(0, Mathf.Sin((bobOffset + Time.time) * 3) * 0.05f, 0);

        //checks to see if the npc has lost hope
        if (NPCArtistStats.Hope < 0)
        {
            playerSpriteIsActive = false;
        }
    }

    //changes the text based on the day 
    public void dayNumber() {
        dialogue.dayDialogue();
    }

    public void talk() {

        talkButton.SetActive(false);
        //plays audio
        FindObjectOfType<AudioManager>().Play("Click");
        //enable the buttons and text
        talkPanel.SetActive(true);

        dialogue.dayDialogue();
   
    }

    public void agree() {

        GlobalData.GetSetCurrentActions -= 1;
        GlobalData.talkedToArtist = true;
       
        switch (NPCArtistStats.Hope) {
            case 10:
                NPCArtistStats.Hope -= 10;
                PlayerStats.Hope -= 5;
                break;
            case 20:
                NPCArtistStats.Hope -= 10;
                PlayerStats.Hope -= 5;
                break;
            case 30:
                NPCArtistStats.Hope += 40;
                PlayerStats.Hope += 5;
                break;
            case 40:
                NPCArtistStats.Hope -= 10;
                PlayerStats.Hope -= 5;
                break;
            case 50:
                NPCArtistStats.Hope += 10;
                PlayerStats.Hope += 5;
                break;
            case 60:
                NPCArtistStats.Hope += 10;
                PlayerStats.Hope += 5;
                break;
            case 70:
                NPCArtistStats.Hope += 10;
                PlayerStats.Hope += 5;
                break;
            case 80:
                NPCArtistStats.Hope -= 40;
                PlayerStats.Hope -= 5;
                break;
            case 0:
                NPCArtistStats.Hope += 70;
                PlayerStats.Hope += 5;
                break;
        }

        talkPanel.SetActive(false);
    }

    public void disagree() {

        GlobalData.GetSetCurrentActions -= 1;
        GlobalData.talkedToArtist = true;

        switch (NPCArtistStats.Hope)
        {
            case 10:
                NPCArtistStats.Hope += 10;
                PlayerStats.Hope += 5;
                break;
            case 20:
                NPCArtistStats.Hope += 10;
                PlayerStats.Hope += 5;
                break;
            case 30:
                NPCArtistStats.Hope -= 40;
                PlayerStats.Hope -= 5;
                break;
            case 40:
                NPCArtistStats.Hope += 10;
                PlayerStats.Hope += 5;
                break;
            case 50:
                NPCArtistStats.Hope -= 10;
                PlayerStats.Hope -= 5;
                break;
            case 60:
                NPCArtistStats.Hope -= 10;
                PlayerStats.Hope -= 5;
                break;
            case 70:
                NPCArtistStats.Hope -= 10;
                PlayerStats.Hope -= 5;
                break;
            case 80:
                NPCArtistStats.Hope += 10;
                PlayerStats.Hope += 5;
                break;
            case 0:
                NPCArtistStats.Hope -= 50;
                PlayerStats.Hope -= 5;
                break;
        }

        talkPanel.SetActive(false);
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

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            inRange = true;
            if (playerSpriteIsActive && GlobalData.talkedToArtist == false)
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

}
