using System.Collections;
using System.Collections.Generic;
using Unity.Jobs;
using UnityEngine;

public class TextScrambler : MonoBehaviour {

    [TextArea(5, 10)]
    public string StringBuffer;

    [SerializeField]
    private string ActualString = "";

    [SerializeField]
    private string StringScrambled = "";

    //private char[] stringShowing;

    private float hopeValue;
 
    private float ActualPercentScrambled = 1.0f;

    public bool forceUpdate = false;

    // Use this for initialization
    void Start ()
    {
    }

    // Update is called once per frame
    void Update ()
    {
        hopeValue = (float)PlayerStats.Hope / 100.0f;

        if (ActualString != StringBuffer)
        {
            ActualString = StringBuffer;
            StringScrambled = "";
            SentanceScramble();
        }

        if (hopeValue != ActualPercentScrambled || forceUpdate)
        {
            string stringToShow = "";
            if (hopeValue > 0.9f)
            {
                stringToShow = ActualString;
            }
            else if (hopeValue < 0.1f)
            {
                stringToShow = StringScrambled;
            }
            else
            {
                char[] newString = new char[ActualString.Length];
                newString = StringScrambled.ToCharArray();

                for (int i = 0; i < Mathf.RoundToInt(hopeValue * (float)ActualString.Length); i++)
                {
                    int iRandIndex = Random.Range(0, ActualString.Length - 1);

                    int breakout = 0;
                    while(newString[iRandIndex] == ActualString.ToCharArray()[iRandIndex])
                    {
                        iRandIndex = Random.Range(0, ActualString.Length - 1);

                        breakout++;
                        if (breakout > ActualString.Length)
                        {
                            break;
                        }
                    }
                    newString[iRandIndex] = ActualString.ToCharArray()[iRandIndex];
                    stringToShow = new string(newString);
                }
            }

            this.GetComponent<UnityEngine.UI.Text>().text = "";
            this.GetComponent<UnityEngine.UI.Text>().text = stringToShow;

            ActualPercentScrambled = hopeValue;
            forceUpdate = false;
        }
    }

    private void SentanceScramble()
    {
        string[] splitSentence = ActualString.Split(' ');
        foreach (string word in splitSentence)
        {
            string Scrambled = Scramble(word);
            if (StringScrambled.Length == 0)
            {
                StringScrambled = Scrambled;
            }
            else
            {
                StringScrambled = StringScrambled + ' ' + Scrambled;
            }
        }

        UnityEngine.UI.Text textToChange = this.GetComponent<UnityEngine.UI.Text>();
        textToChange.text = StringScrambled;
    }
    private string Scramble(string _input)
    {
        char[] chars = _input.ToCharArray();

        for (int i = 0; i < chars.Length; i++)
        {
            int r;
            if (chars[i] > 65 && chars[i] < 90)
            {
                r = Random.Range(65, 90);
            }
            else
            {
                r = Random.Range(97, 122);
            }
            chars[i] = (char)r;
        }
        return new string(chars);
    }


}