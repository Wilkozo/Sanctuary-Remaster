using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageBox : MonoBehaviour
{
    public GameObject messageBg;
    public Text messageBox;
    private Image bg;
    public float messageTime = 3f;
    private float clearTimer = 0f;
    private bool textCleared = true;

    void Start()
    {
        messageBox = GetComponent<Text>();
        bg = messageBg.GetComponent<Image>();
        //ClearMessage();
    }

    public void DisplayMessage(string message, float duration)
    {
        if (messageBox == null)
            messageBox = GetComponent<Text>();
        messageBox.text = message.ToString();
        clearTimer = duration;
        textCleared = false;
    }

    void Update()
    {
        clearTimer -= Time.deltaTime;

        if (clearTimer <= 0 && textCleared == false)
        {
            ClearMessage();
        }

        bg.enabled = !textCleared;
    }

    void ClearMessage()
    {
        messageBox.text = "";
        textCleared = true;
    }
}
