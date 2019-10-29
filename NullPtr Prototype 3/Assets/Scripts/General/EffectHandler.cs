using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectHandler : MonoBehaviour
{
    public ParticleSystem goodEffect;
    public ParticleSystem badEffect;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void Burst(bool isGood)
    {
        if (isGood)
        {
            FindObjectOfType<AudioManager>().Play("Correct");
            goodEffect.Stop();
            goodEffect.Play();
        }
        else
        {
            FindObjectOfType<AudioManager>().Play("Incorrect");
            badEffect.Stop();
            badEffect.Play();
        }
    }
}
