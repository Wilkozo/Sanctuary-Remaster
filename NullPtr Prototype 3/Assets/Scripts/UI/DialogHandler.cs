using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[System.Serializable]
public class DialogStucture
{
    [TextArea(2, 10)]
    public string MainDialog;

    public string Correct;
    [Range(1, 25)]
    public int Reward = 10;

    public string Wrong;
    [Range(0, -25)]
    public int Punishment = -10;

    [HideInInspector]
    public bool isUsed = false;
}
public class DialogHandler : MonoBehaviour {

    public TextScrambler MainText;
    public GameObject buttonCorrect;
    public GameObject buttonWrong;

    public GameObject desk;

    [Range(1, 10)]
    public int NumberOfQuestions = 1;
    private int questionsDone = 1;

    public DialogStucture[] dialogSets;

    int prevAnswerIndex = 0;
    private bool coinFlip = false;
    // Use this for initialization
    void Start () {
        GetNewQuestion();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CallForNextQuestion(bool answerCorrect)
    {
        MainText.forceUpdate = true;
        if (answerCorrect)
        {
            PlayerStats.Hope += dialogSets[prevAnswerIndex].Reward;
        }
        else
        {
            PlayerStats.Hope += dialogSets[prevAnswerIndex].Punishment;
            GameObject.Find("BadEffect");
        }

        if (questionsDone < NumberOfQuestions)
        {
            if (GetNewQuestion())
            {
                questionsDone++;
            }
            else
            {
                questionsDone = NumberOfQuestions;
            }
            
        }
        else
        {
            GlobalData.TimeOfDay = 2;
            FindObjectOfType<MessageBox>().DisplayMessage("Time to head home", 5f);
            desk.GetComponent<Desk>().Leave();
            foreach (DialogStucture item in dialogSets)
            {
                item.isUsed = false;
            }
        }
    }

    bool GetNewQuestion()
    {
        MainText.forceUpdate = true;
        RandButtons();

        prevAnswerIndex = Random.Range(0, dialogSets.Length);

        if (dialogSets[prevAnswerIndex].isUsed == true)
        {
            bool allUsed = true;
            for (int i = 0; i < dialogSets.Length; i++)
            {
                if (!dialogSets[i].isUsed)
                {
                    prevAnswerIndex = i;
                    allUsed = false;
                    break;
                }
            }

            if (allUsed)
            {
                return false;
            }
        }
        

        MainText.StringBuffer = dialogSets[prevAnswerIndex].MainDialog;
        buttonCorrect.GetComponentInChildren<Text>().text = dialogSets[prevAnswerIndex].Correct;
        buttonWrong.GetComponentInChildren<Text>().text = dialogSets[prevAnswerIndex].Wrong;
        dialogSets[prevAnswerIndex].isUsed = true;

        return true;
    }
    void RandButtons()
    {
        Vector3 buttonCorrectPos = buttonCorrect.transform.position;
        Vector3 buttonWrongPos = buttonWrong.transform.position;

        float coinFlip = Random.Range(0.0f, 1.0f);
        if (coinFlip > 0.5f)
        {
            buttonCorrectPos = buttonWrong.transform.position;
            buttonWrongPos = buttonCorrect.transform.position;

            buttonCorrect.transform.position = buttonCorrectPos;
            buttonWrong.transform.position = buttonWrongPos;
        }

    }
}
