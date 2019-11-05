using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // player bobbing
        this.transform.localPosition = new Vector3(this.transform.localPosition.x, Mathf.Sin(Time.time * 3) * 0.01f + this.transform.localPosition.y, this.transform.localPosition.z);

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal * speed, 0.0f, moveVertical * speed);
        //transform.LookAt(transform.position + movement);
        rb.velocity = movement;
    }
}
