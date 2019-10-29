using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BusWheels : MonoBehaviour {

    private Bus bus;
    private bool isMoving;
    private bool isLeaving;

    // Use this for initialization
    void Start ()
    {
        bus = FindObjectOfType<Bus>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (bus.busCalled && !isMoving)
        {
            transform.DORotate(new Vector3(0, 0, -6000f), bus.tweenDuration, RotateMode.LocalAxisAdd).SetEase(Ease.OutCubic);
            isMoving = true;
        }
        if ((bus.busRejected || bus.playerBoarded) && !isLeaving)
        {
            transform.DORotate(new Vector3(0, 0, -9000f), bus.tweenDuration, RotateMode.LocalAxisAdd).SetEase(Ease.InSine);
            isLeaving = true;
        }

        if (bus.reachedLeave)
        {
            isMoving = false;
            isLeaving = false;
        }
	}
}
