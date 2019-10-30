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

        switch (NPCArtistStats.Hope)
        {
            case 10:
                scrambler.StringBuffer = "I must be cursed or something, my parents will never love me. I'm just so pointless. I'm gonna end it all";
                scrambler.forceUpdate = true;
                break;
            case 20:
                scrambler.StringBuffer = "Why am I so stupid. Even babies should be able to understand this. I'm so useless. I should just give up";
                scrambler.forceUpdate = true;
                break;
            case 30:
                scrambler.StringBuffer = "I can't understand any of this. It's all gibberish. I'm sure that if I keep studying I'll get it eventually right?";
                scrambler.forceUpdate = true;
                break;
            case 40:
                scrambler.StringBuffer = "What am I talking about, making manga? That's such a stupid idea. I can barely read this dumb paper. Should I just focus on becoming an accountant like my Dad wants me to?";
                scrambler.forceUpdate = true;
                break;
            case 50:
                scrambler.StringBuffer = "My parents support me in my studies, but I feel annoyed at how little progress I make. I have to spend so much time at school. Should I just go and have fun with the others?";
                scrambler.forceUpdate = true;
                break;
            case 60:
                scrambler.StringBuffer = "This is so hard to understand. It hurts my brain to stare at this paper for so long. I put in the time, but do you think I should get extra lessons?";
                scrambler.forceUpdate = true;
                break;
            case 70:
                scrambler.StringBuffer = "This must not be my strong suit. I much prefer drawing anyways. Do you think I'm good enough to be a manga artist?";
                scrambler.forceUpdate = true;
                break;
            case 80:
                scrambler.StringBuffer = "I've got to thank you for boosting my confidence, but... do you think I'm ... good enough. I've been giving it my all but what if I'm not good enough?";
                scrambler.forceUpdate = true;
                break;
            default:
                scrambler.StringBuffer = "Man, I don't understand this at all. I spend all my time staring at this paper and it all looks ... jumbled? Does that make any sense?";
                scrambler.forceUpdate = true;
                break;

        }

    }
}
