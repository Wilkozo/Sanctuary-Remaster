using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DreamPlayer : MonoBehaviour
{
    public Transform player;
    public Transform mirror;
    private GameObject playerSprite;
    private Vector2 iniPos;

    void Start()
    {

        playerSprite = transform.Find("PlayerSprite").gameObject;
    }

    void Update()
    {
        transform.position = (new Vector3(-player.transform.position.x + mirror.position.x * 2, player.transform.position.y, player.transform.position.z));
        playerSprite.transform.localPosition = new Vector3(0, Mathf.Sin(Time.time * 3) * 0.05f, 0);

    }
}
