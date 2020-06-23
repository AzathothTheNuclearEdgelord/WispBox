using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed = 10f;
    private float randomSpeed;

    private float randomAngle;
    public float radius = 3;
    public float minRadius = 1;
    public int petals = 5;
    public GameObject body;
    
    // Start is called before the first frame update
    void Start()
    {
        randomSpeed = Random.Range(10, 20);
        randomAngle = Random.Range(0, 50000);
        print(randomAngle);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(Vector3.up, speed*Time.deltaTime);
        transform.position = CalucaltePoint();
        randomAngle += randomSpeed * Time.deltaTime * Mathf.Deg2Rad;
        transform.LookAt(CalucaltePoint());

        //GameObject go = Instantiate(body, transform.position, transform.rotation);
        //Destroy(go, 3);
    }
    
    Vector3 CalucaltePoint()
    {
        float currentRadius = Mathf.Cos(randomAngle * petals) + 2 * radius;
        float x = Mathf.Cos(randomAngle * 0.235f) * (currentRadius * Mathf.Sin(randomAngle * 0.023425f));
        float y = Mathf.Cos(randomAngle * 1.1234f) * (currentRadius * Mathf.Cos(randomAngle * 0.12356f));
        float z = Mathf.Sin(randomAngle) * (currentRadius * Mathf.Sin(randomAngle * 0.134656f));
        return new Vector3(x, y, z);
    }
}
