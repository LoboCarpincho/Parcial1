using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbitate : MonoBehaviour
{
    public float speed = 15;
    public Transform target;

    void Update()
    {
        this.transform.RotateAround(target.transform.position, Vector3.up, speed*Time.deltaTime);
    }
}
