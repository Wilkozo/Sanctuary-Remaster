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
        //scrambler.StringBuffer = "IDK";
        //scrambler.forceUpdate = true;
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
                break;
            //day 3
            case 3:
                break;
            //day 4
            case 4:
                break;
            //day 5
            case 5:
                break;
            //day 6
            case 6:
    
                break;
            //day 7
            case 7:
 
                break;
            default:
   
                break;
        }
    }
}
