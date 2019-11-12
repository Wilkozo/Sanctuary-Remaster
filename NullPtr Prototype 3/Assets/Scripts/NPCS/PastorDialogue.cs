using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PastorDialogue : MonoBehaviour
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
                scrambler.StringBuffer = "How are you feeling, my child? Remember no matter how bleak it looks, it will get better as long as you believe. Right?";
                scrambler.forceUpdate = true;
                break;
            case 10:
                scrambler.StringBuffer = "God has abandoned us in our time of need. All I feel is pain and suffering. If this is the life we must lead then I shall end it";
                scrambler.forceUpdate = true;
                break;
            case 20:
                scrambler.StringBuffer = "What's the point? This is so tiring. All you people are the same. 'Awe look at me, I'm depressed.' It is the punishment from God";
                scrambler.forceUpdate = true;
                break;
            case 30:
                scrambler.StringBuffer = "Wow, you don't look so good. That's ok though I can give you some help.... just ... just give me a little time, unless you need help now";
                scrambler.forceUpdate = true;
                break;
            case 40:
                scrambler.StringBuffer = "Who am I kidding I've got no time for this. There are so many people I've got to help it's overwhelming. I want to be there, so I don't have time for a therapist. I'm doing fine right?";
                scrambler.forceUpdate = true;
                break;
            case 50:
                scrambler.StringBuffer = "Gosh there are a lot of people with depression. I'm glad God put me on this Earth with the ability to help each and everyone of them. I've got to help, don't you agree?";
                scrambler.forceUpdate = true;
                break;
            case 60:
                scrambler.StringBuffer = "It's ok to feel bad sometimes. I'm always here for people 24/7. I am a messenger of God and I believe I am the only one who can help";
                scrambler.forceUpdate = true;
                break;
            case 70:
                scrambler.StringBuffer = "I'm glad to see that you are looking better, I'm so glad ... but I don't know. I just feel tired all the time. I just gotta keep focusing on helping others";
                scrambler.forceUpdate = true;
                break;
            case 80:
                scrambler.StringBuffer = "I'm sorry I can't help you today. I need to spend some time to focus on myself. I've got a therapy session in 20, but I don't know I've always been in control, maybe I should just forget about it";
                scrambler.forceUpdate = true;
                break;
            case 90:
                scrambler.StringBuffer = "You were, right. I spent so mych time looking after those who needed support and I forgot to look after myself. The best thing I ever did";
                scrambler.forceUpdate = true;
                break;
            //do nothing
            default:
                scrambler.StringBuffer = "How are you feeling, my child? Remember no matter how bleak it looks, it will get better as long as you believe. Right?";
                scrambler.forceUpdate = true;
                break;

        }

    }
}
