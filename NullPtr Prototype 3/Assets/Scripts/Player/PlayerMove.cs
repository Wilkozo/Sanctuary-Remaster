using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class PlayerMove : MonoBehaviour {

    //[SerializeField] private bool FacingDir;
    [SerializeField] private float moveSpeed = 5.0f;
    [SerializeField] private GameObject targetObject;
    [SerializeField] private GameObject scriptPiggy;

    private GameObject playerSprite;
    private Navigator nav;
    private bool reachedTarget = false;
    private bool inited = false;
    private int sign = 0;

    private SceneSwitcher sceneSwitcher;
    private Rigidbody2D rb;

    public Vector2 iniPos;

    private string prevScene;
    private void Awake()
    {

        sceneSwitcher = FindObjectOfType<SceneSwitcher>();
        SetStartPosition();

        playerSprite = transform.Find("PlayerSprite").gameObject;

        rb = GetComponent<Rigidbody2D>();
        moveSpeed = 5.0f;

    }

    void Start()
    {

        //SetStartPosition();

    }

    void Update()
    {
        // player bobbing
        playerSprite.transform.localPosition = new Vector3(0, Mathf.Sin(Time.time * 3) * 0.05f, 0);


        float moveHorizontal = Input.GetAxis("Horizontal");

        Vector2 movement = new Vector2(moveHorizontal * moveSpeed, 0.0f);

        rb.velocity = movement;


        //sign = 0;
        //if (!reachedTarget)
        //{
        //    if (transform.position.x < targetObject.transform.position.x)
        //    {
        //        transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        //        sign = 1;
        //    }
        //    else
        //    {
        //       transform.localScale = new Vector3(-1.0f, 1.0f,  1.0f);
        //        sign = -1;
        //    }
        //}

        //float moveVector = movespeed * Time.deltaTime * sign;
        //transform.Translate(Vector3.right * moveVector, Space.World);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Target")
        {
            reachedTarget = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Target")
        {
            reachedTarget = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Mirror")
        {
            Dream mirror = collision.gameObject.GetComponent<Dream>();
            mirror.PushBack();
            transform.DOMoveX(transform.position.x - 1f, 0.5f, false).SetEase(Ease.OutSine);
        }
    }

    private void SetStartPosition()
    {
        prevScene = GlobalData.LastScene;
        Debug.Log(prevScene);
        string curScene = SceneManager.GetActiveScene().name;

        if (curScene == "SchoolExt" && prevScene == "HomeExt") //Outside Home -> Outside School
        {
            iniPos = new Vector2(-3.8f, -2.75f);
        }
        else if (curScene == "HomeExt" && prevScene == "SchoolExt") //Outside School -> Outside Home
        {
            iniPos = new Vector2(4.75f, -2.75f);
        }
        else if (prevScene == "School" && curScene == "SchoolExt") //Inside School -> Outside School
        {
            iniPos = new Vector2(4.36f, -2.75f);
        }
        else if (prevScene == "Home" && curScene == "HomeExt") //Inside Home -> Outside Home
        {
            iniPos = new Vector2(-3.48f, -2.75f);
        }
        else if (prevScene == "HomeExt" && curScene == "Home") //Outside Home -> Inside Home 
        {
            iniPos = new Vector2(-3.48f, -2.75f);

            // Advance time to night
            if (GlobalData.TimeOfDay == 1)
            {
                GlobalData.TimeOfDay = 2;
            }
        }
        else if (prevScene == "Home" && curScene == "FightClub") //Inside Home -> Dream
        {
            iniPos = new Vector2(-5.0f, -2.75f);
        }
        else if (prevScene == "FightClub" && curScene == "Home") //Dream -> Inside Home
        {
            iniPos = new Vector2(2.6f, -2.75f);
            if (GlobalData.Victory)
            {
                FindObjectOfType<MessageBox>().DisplayMessage("You persisted and found victory!", 10f);
                Debug.Log(GlobalData.Victory);
            }
            else
            {
                FindObjectOfType<MessageBox>().DisplayMessage("Day: " + GlobalData.Day, 5);
            }
        }

        else //Any other "non special" cases
        {
            iniPos = new Vector2(-3.48f, -2.75f);
        }
        this.transform.position = iniPos;
    }
}
