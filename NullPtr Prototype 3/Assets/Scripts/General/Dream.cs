using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Dream : MonoBehaviour {

    private float hopeValue;
    private float positionInitial;
    public float positionFinal;
    private float positionCurrent;
    private float travelDistance;

    public float moveDelay = 0f;

    private bool hasStartedMove;
    private float age;
    private float pushBackStart;

    public float moveSpeed;

    public float pushBackDuration = 0.5f;
    public float pushBackStrength;
    private float pushAmount;
    private float moveDir = 1;

    public bool dreamEnded;
    public bool dreamVictory;

    public float maxTime;

    public bool canPushBack = true;

    private SceneSwitcher sceneSwitcher;

	// Use this for initialization
	void Start ()
    {
        sceneSwitcher = FindObjectOfType<SceneSwitcher>();

        hopeValue = PlayerStats.Hope;
        pushAmount = Mathf.Pow((hopeValue/100), 1.5f) * (pushBackStrength);
        Debug.Log(pushAmount);

        // Set initial position of mirror based on current hope
        positionInitial = hopeValue / 15;
        //transform.position = new Vector2(positionInitial, transform.position.y);
        travelDistance = Mathf.Abs(positionFinal - positionInitial);

    }
	
	// Update is called once per frame
	void Update ()
    {
        age += Time.deltaTime;
        if (age >= maxTime)
        {
            canPushBack = false;
        }

        positionCurrent = transform.position.x;

        float duration = travelDistance / moveSpeed;

        if (Input.GetKeyUp("space"))
        {
            pushBackStart = age;
            hasStartedMove = false;
            moveDir = -1;
        }

        if ((moveDir == -1) && (pushBackStart + pushBackDuration <= age))
        {
            hasStartedMove = false;
            moveDir = 1;
        }

        // Start moving mirror when moveDelay has been reached
        if (age >= moveDelay && !hasStartedMove)
        {
            //transform.DOMoveX(positionFinal * moveDir, duration, false).SetEase(Ease.InOutSine);

            float moveVector = moveSpeed * Time.deltaTime;
            transform.Translate(Vector3.left * moveVector, Space.World);
            //hasStartedMove = true;
        }

        float offsetFromCenter = Mathf.Abs(transform.position.x);

        if (offsetFromCenter >= 9f && !dreamEnded)
        {
            if (Mathf.Sign(transform.position.x) == 1)
            {
                DreamEnd(true);
            }
            else
            {
                DreamEnd(false);
            }

        }
        
    }


    public void PushBack()
    {
        if (canPushBack)
        {
            transform.DOMoveX(transform.position.x + pushAmount, pushBackDuration, false).SetEase(Ease.OutSine);

            travelDistance = Mathf.Abs(positionFinal - positionCurrent);
            float duration = travelDistance / moveSpeed;
        }

        //transform.DOMoveX(positionFinal * moveDir, duration, false).SetEase(Ease.InOutSine);
    }

    public void DreamEnd(bool victory)
    {
        if (victory)
        {
            PlayerStats.Hope += 20;
            GlobalData.Victory = true;
        }
        else
        {
            PlayerStats.Hope += 15;
        }
        sceneSwitcher.SceneSwitch("Home");
        GlobalData.TimeOfDay = 0;
        dreamEnded = true;
    }
}
