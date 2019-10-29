using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DialScript : MonoBehaviour {

    public GameObject sword;

    public GameObject dial;
    private bool bDrawing;
    private Vector3 drawStart;
    private GameObject prevObject;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonUp("Fire2"))
        {
            sword.transform.DOPunchRotation(new Vector3(0.0f, 0.0f, -50.0f), 0.25f, 0, 0.1f);
        }

        if (Input.GetButton("Fire3"))
        {
            dial.SetActive(true);
           
            if (!bDrawing)
            {
                Vector2 mousePos2d = GetMouseInWorld();
                dial.transform.position = new Vector3(mousePos2d.x,mousePos2d.y , -9);
                bDrawing = true;
            }
        }
        else if (Input.GetButtonUp("Fire3"))
        {
            dial.SetActive(false);
            bDrawing = false;
        }

        if(bDrawing)
        {
            Vector3 mousePos3d = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2d = new Vector2(mousePos3d.x, mousePos3d.y);

            RaycastHit2D hitCollider = Physics2D.Linecast(dial.transform.position, mousePos2d);

            if (hitCollider.collider != null)
            {
                if((hitCollider.collider.gameObject.tag == "LEFT") || (hitCollider.collider.gameObject.tag == "RIGHT") ||
                    (hitCollider.collider.gameObject.tag == "UP") || (hitCollider.collider.gameObject.tag == "DOWN"))
                {
                    if(prevObject!= null)
                    {
                        Color tmp = prevObject.GetComponent<SpriteRenderer>().color;
                        tmp.a = 255/255f;
                        prevObject.GetComponent<SpriteRenderer>().color = tmp;
                    }

                    Color wat = hitCollider.collider.gameObject.GetComponent<SpriteRenderer>().color;
                    wat.a = 100/255f;
                    hitCollider.collider.gameObject.GetComponent<SpriteRenderer>().color = wat;

                    prevObject = hitCollider.collider.gameObject;
                }
            }
            else
            {
                if(prevObject!= null)
                {
                    Color wat = prevObject.GetComponent<SpriteRenderer>().color;
                    wat.a = 255/255f;
                    prevObject.GetComponent<SpriteRenderer>().color = wat;
                }
            }
        }
    }

    Vector2 GetMouseInWorld()
    {
        Vector3 mousePos3d = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 mousePos2d = new Vector2(mousePos3d.x, mousePos3d.y);

        return mousePos2d;
    }
}
