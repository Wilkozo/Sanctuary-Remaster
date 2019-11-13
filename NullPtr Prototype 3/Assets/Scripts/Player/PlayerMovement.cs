using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;

    public Vector3 iniPos;

    private Rigidbody rb;
    private string prevScene;
    // Start is called before the first frame update
    private void Awake()
    {
        SetStartPosition();
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // player bobbing
        this.transform.localPosition = new Vector3(this.transform.localPosition.x, Mathf.Sin(Time.time * 3) * 0.005f + this.transform.localPosition.y, this.transform.localPosition.z);

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal * speed, 0.0f, moveVertical * speed);
        //transform.LookAt(transform.position + movement);
        rb.velocity = movement;
    }

    private void SetStartPosition()
    {
        prevScene = GlobalData.LastScene;
        Debug.Log(prevScene);
        string curScene = SceneManager.GetActiveScene().name;

        if (curScene == "TestScene01" && prevScene == "Home") //Inside Home -> Town
        {
            iniPos = new Vector3(-4.45f, 1.66f, 12.1f);
        }
        else if (curScene == "TestScene01" && prevScene == "TestScene02") //Outside School -> Keith
        {
            iniPos = new Vector3(-14.45f, 1.66f, 5.0f);
        }
        else if (curScene == "TestScene01" && prevScene == "School") //Outside School -> Town
        {
            iniPos = new Vector3(25.0f, 1.66f, 22.0f);
        }
        else if (prevScene == "Store" && curScene == "TestScene01")
        {
            iniPos = new Vector3(-29.52168f, 1.66f, 20.8429f);
        }
        else if (prevScene == "Church" && curScene == "TestScene01")
        {
            iniPos = new Vector3(16.79f, 1.66f, -22.01f);
        }
        else if (prevScene == "Church" && curScene == "TestScene01")
        {
            iniPos = new Vector3(-24.61f, 1.66f, -12.71f);
        }
        else //Any other "non special" cases
        {
            iniPos = transform.position;
        }
        this.transform.position = iniPos;
    }
}
