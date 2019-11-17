using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class breakUpDialogue : MonoBehaviour
{

    private Text dialogue;

    private TextScrambler scrambler;


    public void Start()
    {
        scrambler = this.GetComponent<TextScrambler>();

        scrambler.forceUpdate = true;
        dayDialogue();
    }

    public void dayDialogue()
    {

        switch (NPCBreakUp.Hope)
        {
            case 0:
                scrambler.StringBuffer = "*sob* Why did you leave me JEssica? I was a good boyfriend. I listened and I cared. I loved you so much. *sob* Was it me?";
                scrambler.forceUpdate = true;
                break;
            case 10:
                scrambler.StringBuffer = "Am I that undesirable? I must have been a horrible, toxic boyfriend. I made Jessica hate me so much and ruined her as a perfect girl. I might as well just kill myself and end my suffering.";
                scrambler.forceUpdate = true;
                break;
            case 20:
                scrambler.StringBuffer = "Woman are trash and all women are the same. Just playing with honest, good guys and using before throwing them in the trash. I can't believe I was so gullible. Womene only belong in the kitchen";
                scrambler.forceUpdate = true;
                break;
            case 30:
                scrambler.StringBuffer = "I'm so sad all the time. I'll never find love again. I love you Jessica! Please take me back *sob* Who cares if we weren't compatible, I can change";
                scrambler.forceUpdate = true;
                break;
            case 40:
                scrambler.StringBuffer = "Didn't she know how much effort and energy it took to get to understand her? What a waste of my time. Shes's so selfish for wanting to 'be free'. She belongs to me";
                scrambler.forceUpdate = true;
                break;
            case 50:
                scrambler.StringBuffer = "Females are stupid. I mean, you pour your heart into them and they turn around and spit in your face. THey can all rot in hell. AHHHHHH! So why do I still have feelings for her? is gonna be tough to move on";
                scrambler.forceUpdate = true;
                break;
            case 60:
                scrambler.StringBuffer = "She left me. I came home and she told me we were growing apart? What does that even mean? Did she even love me? Why shouldn't we be together? Maybe I should just move on";
                scrambler.forceUpdate = true;
                break;
            case 70:
                scrambler.StringBuffer = "I can't believe she lead me on. If she knew she didn't love me, why did she stay with me for a year? I hate her so much. She can rot in hell for all I care.... but it's not really her fault is it?";
                scrambler.forceUpdate = true;
                break;
            case 80:
                scrambler.StringBuffer = "I'm sorry I overreacted. Truth be told, she was right, we weren't right for each other. But maybe we can make it work all I need to do is give her what she wants right?";
                scrambler.forceUpdate = true;
                break;
            case 90:
                scrambler.StringBuffer = "Hey, I'm glad to see you. Your advice really helped> I've moved on and recently found this new person who really clicks with me!";
                scrambler.forceUpdate = true;
                break;
            //do nothing
            default:
                scrambler.StringBuffer = "*sob* Why did you leave me JEssica? I was a good boyfriend. I listened and I cared. I loved you so much. *sob* Was it me?";
                scrambler.forceUpdate = true;
                break;

        }

    }
}
