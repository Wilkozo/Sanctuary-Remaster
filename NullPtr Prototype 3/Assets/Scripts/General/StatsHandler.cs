using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class StatsHandler : MonoBehaviour {

    public float hopeValue;
    [SerializeField] private GameObject PPHappy;
    [SerializeField] private ParticleSystem fogBack;
    [SerializeField] private ParticleSystem fogFront;
    private PostProcessVolume volume;

	// Use this for initialization
	void Start ()
    {
        volume = PPHappy.GetComponent<PostProcessVolume>();
        hopeValue = PlayerStats.Hope / 100;
	}
	
	// Update is called once per frame
	void Update ()
    {


        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //PlayerStats.Hope += 10;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //PlayerStats.Hope -= 10;
        }
        PlayerStats.Hope = Mathf.Clamp(PlayerStats.Hope, 0, 100);

        hopeValue = (float)PlayerStats.Hope / 100;
        //PlayerStats.Hope = hopeValue;
        volume.weight = hopeValue;
    }
}
