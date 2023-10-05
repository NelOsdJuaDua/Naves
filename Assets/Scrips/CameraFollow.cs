using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject target;

    public float verticalOffset; //dar un pequeño aire

    public void FixedUpdate()
    {
        transform.position = new Vector3(0, target.transform.position.y + verticalOffset, transform.position.z);
    }
    
}
