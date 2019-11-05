using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogEffect : MonoBehaviour
{
    [SerializeField] private ParticleSystem FogLayer1;
    [SerializeField] private ParticleSystem FogLayer2;
    ParticleSystem.EmissionModule fogModule1;
    ParticleSystem.EmissionModule fogModule2;

    public Light directionLight;


    private void Start()
    {
        directionLight = FindObjectOfType<Light>();
        //PlayerStats.Hope = 10;
        fogModule1 = FogLayer1.emission;
        fogModule2 = FogLayer2.emission;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerStats.Hope < 20)
        {
            directionLight.intensity = 0.25f;
            fogModule1.rateOverTime = new ParticleSystem.MinMaxCurve(500);
            fogModule2.rateOverTime = new ParticleSystem.MinMaxCurve(500);
        }
        else if (PlayerStats.Hope < 40)
        {
            directionLight.intensity = 0.45f;
            fogModule1.rateOverTime = new ParticleSystem.MinMaxCurve(8);
            fogModule2.rateOverTime = new ParticleSystem.MinMaxCurve(8);
        }
        else if (PlayerStats.Hope < 60)
        {
            directionLight.intensity = 0.65f;
            fogModule1.rateOverTime = new ParticleSystem.MinMaxCurve(6);
            fogModule2.rateOverTime = new ParticleSystem.MinMaxCurve(6);
        }
        else if (PlayerStats.Hope < 80)
        {
            directionLight.intensity = 0.85f;
            fogModule1.rateOverTime = new ParticleSystem.MinMaxCurve(4);
            fogModule2.rateOverTime = new ParticleSystem.MinMaxCurve(4);
        }
        else if (PlayerStats.Hope < 1000)
        {
            directionLight.intensity = 1.0f;
            fogModule1.rateOverTime = new ParticleSystem.MinMaxCurve(2);
            fogModule2.rateOverTime = new ParticleSystem.MinMaxCurve(2);
        }
    }
}
