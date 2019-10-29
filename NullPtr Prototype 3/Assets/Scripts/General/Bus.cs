using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Bus : MonoBehaviour {

    public float tweenDuration = 6f;
    public float departTime = 3f;
    public GameObject busStopTarget;
    public GameObject busLeaveTarget;
    public GameObject callBusButton;
    public GameObject busStop;
    public GameObject busPrompt;
    public GameObject player;
    public string destination;
    public bool BusIEngineActive = false;
    private PlayerTarget ptarget;
    private Navigator nav;
    private SceneSwitcher sceneSwitcher;
    public bool busCalled;
    private bool reachedTarget = false;
    public bool reachedLeave = false;
    public bool HasArrived = false;
    private bool busStopped;
    private bool busDeparted;
    public bool playerBoarded;
    public bool busRejected;
    public Vector3 positionInitial;
    //private float idleTime = 0;
    private AudioManager BusSfx;
    bool hasClicked = false;

    void Start ()
    {
        nav = busStop.GetComponent<Navigator>();
        positionInitial = transform.position;
        ptarget = FindObjectOfType<PlayerTarget>();
        sceneSwitcher = FindObjectOfType<SceneSwitcher>();
	}

    void Update()
    {
        // Check distance to target
        float dist = Mathf.Abs(busStopTarget.transform.position.x - transform.position.x);
        float dist2 = Mathf.Abs(busLeaveTarget.transform.position.x - transform.position.x);



        if (dist < 0.1)
        {

            reachedTarget = true;
        }
        else
        {
            reachedTarget = false;
        }

        if (dist2 < 0.1)
        {

        }

        if (dist2 < 0.1)
        {

            reachedLeave = true;
        }
        else
        {
            reachedLeave = false;
        }
        if (reachedTarget && !playerBoarded)
        {
            if (BusIEngineActive == false)
            {
                FindObjectOfType<AudioManager>().Play("BusEngineI");
                BusIEngineActive = true;
            }

        }

        if (reachedTarget && !playerBoarded && !busRejected)
        {
            if (HasArrived == false)
            {
                HasArrived = true;
            }
            busPrompt.SetActive(true);
            busCalled = false;
        }

        // When bus reaches departure target
        if (reachedLeave)
        {
            transform.position = positionInitial;
            busRejected = false;
            nav.isActive = true;
            reachedTarget = false;
        }

        // When player requests to board bus
        if (busDeparted)
        {
            departTime = Mathf.MoveTowards(departTime, 0f, Time.deltaTime);
            if (departTime <= 0f)
            {
                if (playerBoarded)
                {
                    sceneSwitcher.SceneSwitch(destination);
                    playerBoarded = false;
                }
                FindObjectOfType<AudioManager>().Stop("BusEngineI");
                departTime = 3.0f;
                busDeparted = false;
            }
        }


        if (busCalled)
        {
            ptarget.isActive = false;
        }
        
	}

    public void CallBus()
    {
        if (hasClicked == false)
        {
            FindObjectOfType<AudioManager>().Play("Click");
            hasClicked = true;
        }
        busCalled = true;
        FindObjectOfType<AudioManager>().Play("BusHornA");
        //FindObjectOfType<AudioManager>().Play("BusEngineA"); // 6.6 7.5
        transform.DOMoveX(busStopTarget.transform.position.x, tweenDuration, false).SetEase(Ease.OutCubic);
        nav.isActive = false;
    }

    public void BoardBus()
    {
        FindObjectOfType<AudioManager>().Play("BusEngineI");
        playerBoarded = true;
        player.SetActive(false);
        busPrompt.SetActive(false);
    }

    public void DepartBus()
    {
        ptarget.isActive = false;
        FindObjectOfType<AudioManager>().Play("BusHornB");
        busPrompt.SetActive(false);
        transform.DOMoveX(busLeaveTarget.transform.position.x, tweenDuration, false).SetEase(Ease.InSine);
        busDeparted = true;
        ptarget.isActive = true;
    }

    public void RejectBus()
    {
        busRejected = true;
        DepartBus();
    }

    public void FastTravel(string scene)
    {
        destination = scene;
        BoardBus();
        DepartBus();
    }
}
