using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PoorDialogue : MonoBehaviour
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

        switch (NPCPoor.Hope)
        {
            case 0:
                scrambler.StringBuffer = "I wish I could buy myself the newest phone. I feel like a total outcast with this outdated brick. My parents gave me money for some new shoes. Maybe I should spend it on a new phone instead";
                scrambler.forceUpdate = true;
                break;
            case 10:
                scrambler.StringBuffer = "I hate this world. Nothing is worth it. No matter how much I work I'll always be outclassed by someone who was born into a rich family. I'm so tempted to end it all *sigh* Maybe if I work hard enough, I can make up the difference?";
                scrambler.forceUpdate = true;
                break;
            case 20:
                scrambler.StringBuffer = "What a cruel world. Just because I've been born into a poor household, I have to work harder for the privileges. I hate all of them. They don't deserve it and I do";
                scrambler.forceUpdate = true;
                break;
            case 30:
                scrambler.StringBuffer = "I wonder if anyone would notice if I stole someone's phone. It's not fair that I have to work after school and I can't afford the newest phones. Their parents will just buy them a new one anyway";
                scrambler.forceUpdate = true;
                break;
            case 40:
                scrambler.StringBuffer = "I'm so busy all the time. I wish I could take some time to hang out with my friends. But I need the cash. It's so unfair. I should just stop working and let the government pay";
                scrambler.forceUpdate = true;
                break;
            case 50:
                scrambler.StringBuffer = "Why do people take things for granted. I work 6 days a week on top of school, yet I constantly see people lose, or break even give away their things. I would kill for those things. I deserve them";
                scrambler.forceUpdate = true;
                break;
            case 60:
                scrambler.StringBuffer = "I can't believe they've got me working so late. If I wasn't so poor, I wouldn't even be here. I should just leave. I should just steal some supplies on the way out.";
                scrambler.forceUpdate = true;
                break;
            case 70:
                scrambler.StringBuffer = "There's a party going on this week edn. Everyone who's anyone is gonna be there. I'm sure missing one day of work won't go amiss. I've earned it.";
                scrambler.forceUpdate = true;
                break;
            case 80:
                scrambler.StringBuffer = "I spend all my free time working. It's very tring but I want to save up for gifts for my parents. They don't have any money to buy themselves anything. It's hard but it'll be worth it to see them smile";
                scrambler.forceUpdate = true;
                break;
            case 90:
                scrambler.StringBuffer = "It was definitely worth working all that time. I may have spent less time with my friends. But being able to help get my family through hard times was all I needed to keep me smiling";
                scrambler.forceUpdate = true;
                break;
            //do nothing
            default:
                scrambler.StringBuffer = "I wish I could buy myself the newest phone. I feel like a total outcast with this outdated brick. My parents gave me money for some new shoes. Maybe I should spend it on a new phone instead";
                scrambler.forceUpdate = true;
                break;

        }

    }
}
