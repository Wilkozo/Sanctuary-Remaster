using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrunkDialogue : MonoBehaviour
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

        switch (NPCDrunk.Hope)
        {
            case 0:
                scrambler.StringBuffer = "*hic* Wha you lookin at? You never seen a adult drinkin in the mornin before? Slaving away at a company who can replace ya whenever don't seem fair. Wha am I saying I shouldn't be drinkin at this time";
                scrambler.forceUpdate = true;
                break;
            case 10:
                scrambler.StringBuffer = "This is teh only thing that bring me joy anymore. who needs anything. Life is pointless an' I'm gonna go out on my terms.";
                scrambler.forceUpdate = true;
                break;
            case 20:
                scrambler.StringBuffer = "I'm not addicted to anything. I can stop anytime, but I choose to do them, cause I'm an adult. As long as I have lots of money to spend. I can do what I want";
                scrambler.forceUpdate = true;
                break;
            case 30:
                scrambler.StringBuffer = "What's the point of working without booze. It's my life and it's now or never. I'm an adult and I can do what I want. I don't have to worry about raising a family";
                scrambler.forceUpdate = true;
                break;
            case 40:
                scrambler.StringBuffer = "Works been tiring recently. I can't seem to care about anything. It's just mindless, soul sucking work. I should find something I really enjoy instead, even if it doesn't make as much money";
                scrambler.forceUpdate = true;
                break;
            case 50:
                scrambler.StringBuffer = "The *hic* problem with people is that they don't know how to treat themselves. They just want to work all the *hic* time. They need to make decisions for mental health, not just wealth";
                scrambler.forceUpdate = true;
                break;
            case 60:
                scrambler.StringBuffer = "The sole purpose of my existence is to make money. I drown my sorrows with cheap booze and tons of it. I need it. I can't function knowing my life is being wasted here. I need alcohol";
                scrambler.forceUpdate = true;
                break;
            case 70:
                scrambler.StringBuffer = "Without alcohol to dull my senses, I can really tell how bad this place is. All they want is results. I'm just a tool to be used. I've saved enough for a boat. I've always wanted to be a sailor";
                scrambler.forceUpdate = true;
                break;
            case 80:
                scrambler.StringBuffer = "I am so excited. I've always dreamt of owning a boat and now I've finally got one. But should I really quit? Maybe it will get better. Sometimes I feel like the money is worth it should I stay?";
                scrambler.forceUpdate = true;
                break;
            case 90:
                scrambler.StringBuffer = "I finally left. Thanks for all your help-. I spent way too many years wasting my time. I'm so glad to be chasing my dreams and travelling the world";
                scrambler.forceUpdate = true;
                break;
            //do nothing
            default:
                scrambler.StringBuffer = "*hic* Wha you lookin at? You never seen a adult drinkin in the mornin before? Slaving away at a company who can replace ya whenever don't seem fair. Wha am I saying I shouldn't be drinkin at this time";
                scrambler.forceUpdate = true;
                break;

        }

    }
}
