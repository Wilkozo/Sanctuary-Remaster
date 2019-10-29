using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkHandler : MonoBehaviour {

    public bool reRoll = false;
    public string[] talkSets;
    private TextScrambler scrambler;
    // Use this for initialization
    void Start () {
        scrambler = this.GetComponent<TextScrambler>();

        if (talkSets.Length > 0)
        {
            int iRandIndex = Random.Range(0, talkSets.Length - 1);
            this.GetComponent<TextScrambler>().StringBuffer = talkSets[iRandIndex];
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (talkSets.Length > 0 && reRoll)
        {
            int iRandIndex = Random.Range(0, talkSets.Length - 1);
            scrambler.StringBuffer = talkSets[iRandIndex];
            scrambler.forceUpdate = true;
            reRoll = false;
        }
    }
}
