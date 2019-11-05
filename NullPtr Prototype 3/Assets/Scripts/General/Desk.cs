using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desk : MonoBehaviour {

    public GameObject sitButton;
    public GameObject leaveButton;

    public GameObject questionBox;

    private PlayerTarget ptarget;
    private Navigator nav;
    private bool questionAnswered;
    //private bool isSitting;

    // Use this for initialization
    void Start()
    {
        ptarget = FindObjectOfType<PlayerTarget>();
        nav = this.GetComponent<Navigator>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void AnswerCorrect()
    {
        questionAnswered = true;
        Leave();
    }

    public void AnswerIncorrect()
    {
        questionAnswered = true;
        Leave();
    }

    public void Sit()
    {
        if (GlobalData.TimeOfDay < 2)
        {
            nav.isActive = false;
            //isSitting = true;
            ptarget.isActive = false;
            sitButton.SetActive(false);

            if (!questionAnswered)
            {
                questionBox.SetActive(true);
            }
        }
        else
        {
            FindObjectOfType<MessageBox>().DisplayMessage("Class has ended.", 2.5f);
        }
        
    }

    public void Leave()
    {
        //isSitting = false;
        questionBox.SetActive(false);

        leaveButton.SetActive(false);
        ptarget.isActive = true;
        
    }
}
