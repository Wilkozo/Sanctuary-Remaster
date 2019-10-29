using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTarget : MonoBehaviour {

    public enum RayTraceDirection
    {
        UP,
        DOWN,
        LEFT,
        RIGHT
    }

    private Vector2 TargetPos; // Target mouse x y
    private Vector3 mousePos3d;
    private Vector2 mousePos2d;
    public ParticleSystem blip;
    public bool isActive = true;
    //[SerializeField] private Input TapButton;
    private Vector2 rayStart;


    public RayTraceDirection mouseDir;

	// Use this for initialization
	void Start ()
    {
        var pos = transform.position.x;
        pos = GlobalData.StartPos;
        TargetPos.x = FindObjectOfType<PlayerMove>().iniPos.x;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetButton("Fire1"))
        {
            SetPosition();
        }
        transform.position = TargetPos;
	}

    private void OnMouseDown()
    {

    }

    private void endRayTrace()
    {
  
    }

    private void SetPosition()
    {
        if (isActive)
        {
            mousePos3d = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos2d = new Vector2(mousePos3d.x, mousePos3d.y);
            TargetPos = mousePos2d;

            blip.Stop();
            blip.Play();
        }

    }
}
