using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class PipeScript : MonoBehaviour
{
    public float moveSpeed = 5;

    void Start()
    {

    }
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        if (transform.position.x < -40)
        {
            Destroy(gameObject);
        }
    }
}
