using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float speed = 2;

    void Update()
    {
        transform.rotation *= Quaternion.AngleAxis (speed * Time.deltaTime, Vector3.up);
    }
}
