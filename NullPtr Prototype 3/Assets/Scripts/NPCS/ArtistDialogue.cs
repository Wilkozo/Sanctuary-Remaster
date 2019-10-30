using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArtistDialogue : MonoBehaviour
{

    private Text dialogue;

    private TextScrambler scrambler;


    public void Start()
    {
        scrambler = this.GetComponent<TextScrambler>();
    }

    //TODO: Add in the dialogue
    public void dayDialogue(int day)
    {
        switch (day)
        {
            //day 1
            case 1:
                scrambler.StringBuffer = "Hello there";
                scrambler.forceUpdate = true;
                break;
            //day 2
            case 2:
                scrambler.StringBuffer = "Hello there";
                scrambler.forceUpdate = true;
                break;
            //day 3
            case 3:
                scrambler.StringBuffer = "Hello there";
                scrambler.forceUpdate = true;
                break;
            //day 4
            case 4:
                scrambler.StringBuffer = "Hello there";
                scrambler.forceUpdate = true;
                break;
            //day 5
            case 5:
                scrambler.StringBuffer = "Hello there";
                scrambler.forceUpdate = true;
                break;
            //day 6
            case 6:
                scrambler.StringBuffer = "Hello there";
                scrambler.forceUpdate = true;
                break;
            //day 7
            case 7:
                scrambler.StringBuffer = "Hello there";
                scrambler.forceUpdate = true;
                break;
            default:
   
                break;
        }
    }
}
