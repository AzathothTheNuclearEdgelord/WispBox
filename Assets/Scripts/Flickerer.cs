using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flickerer : MonoBehaviour
{
    public Light light;
    private float currentRange;
    public float maxRange = 10;
    public float minRange = 2;
    private float currentIntensity;
    public float maxIntensity;
    public float minIntensity;
    void Update()
    {
        currentRange = Random.Range(minRange, maxRange);
        currentIntensity = Random.Range(minIntensity, maxIntensity);
        light.range = currentRange;
        light.intensity = currentIntensity;
    }
}
