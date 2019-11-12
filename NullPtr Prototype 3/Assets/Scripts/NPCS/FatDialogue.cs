using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FatDialogue : MonoBehaviour
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

        switch (NPCPastor.Hope)
        {
            case 0:
                scrambler.StringBuffer = "Why am I tired all the time. I got lots of sleep last night and I eat all the time so I should have energy to spare. It must be genetics";
                scrambler.forceUpdate = true;
                break;
            case 10:
                scrambler.StringBuffer = "All I want to do is eat. I don't care about anything. Food is my only comfort in this torturous existence. I hate this world. I don't think I'm coming back from this.";
                scrambler.forceUpdate = true;
                break;
            case 20:
                scrambler.StringBuffer = "I can eat what I want OK. It's my body. I'll eat my problems away, no one can stop me from being myself. Don't judge me. No one will miss me if I die from diabetes or vitamin deficiency";
                scrambler.forceUpdate = true;
                break;
            case 30:
                scrambler.StringBuffer = "I don't have an eating problem. I eat because it makes me happy. When I have a tough day, I eat. When I'm stressed I eat. Eating is harmless and is a good way to distress";
                scrambler.forceUpdate = true;
                break;
            case 40:
                scrambler.StringBuffer = "I tried eating vegetables and it didn't help at all. Chips are potato, pizzas have tomato, burgers have lettuce and tomato. That's all the vegetables I need";
                scrambler.forceUpdate = true;
                break;
            case 50:
                scrambler.StringBuffer = "I'm so demotivated all the time. I want to try and lose weight, but I can't get out of bed in the morning. It's not fair. I might as well give up";
                scrambler.forceUpdate = true;
                break;
            case 60:
                scrambler.StringBuffer = "I love fast food. It's so tasty. I could eat nothing but fast food for the rest of my life and I'd love it. But I do get sleepy a lot. Maybe I shouldn't use it as a crutch";
                scrambler.forceUpdate = true;
                break;
            case 70:
                scrambler.StringBuffer = "I wonder if I'm too unhealthy. I hurt all the time, I have trouble breathing, heck, I get out of breath just from standing up. This is way too much hassle to deal with all the time. Should I cut down on fast food";
                scrambler.forceUpdate = true;
                break;
            case 80:
                scrambler.StringBuffer = "I hate the taste of vegetables. Lettuce tastes bitter, carrots are bland and tomatoes are too acidic. I tried going for a run too fast and it was too hard. I don't need exercise";
                scrambler.forceUpdate = true;
                break;
            case 90:
                scrambler.StringBuffer = "I did it, this morning I had the best sleep I've had in ages. I went for a walk in the morning. I know that it'll take a while but it's still an improvement";
                scrambler.forceUpdate = true;
                break;
            //do nothing
            default:
                scrambler.StringBuffer = "Why am I tired all the time. I got lots of sleep last night and I eat all the time so I should have energy to spare. It must be genetics";
                scrambler.forceUpdate = true;
                break;

        }

    }
}
