using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class WispManager : MonoBehaviour
{
    private int wispCount;
    public GameObject wisp;

    private void Start()
    {
        wispCount = Random.Range(3, 6);
        print("Amount of wisps spawned " + wispCount);
        for (int i = 0; i < wispCount; i++)
        {
            Instantiate(wisp, transform.position, transform.rotation);
        }    

    }
}
