using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawn : MonoBehaviour
{
    public GameObject cloud;
    public float spawnrate = 2;
    private float timer = 0;
    public float heightOffset = 2;

    void Start()
    {
        spawnCloud();
    }

    void Update()
    {
        if (timer < spawnrate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnCloud();
        }
    }
    void spawnCloud()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(cloud, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint)), transform.rotation);
        timer = 0;
    }
}
