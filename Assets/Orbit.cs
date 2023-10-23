using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{

    public Transform center;  // Assign your camera here
    public float orbitRadius = 30f;
    public float orbitSpeed = 57.6f;  // degrees per second

    void Update()
    {
        float angle = orbitSpeed * Time.time;
        float x = center.position.x + orbitRadius * Mathf.Cos(angle * Mathf.Deg2Rad);
        float z = center.position.z + orbitRadius * Mathf.Sin(angle * Mathf.Deg2Rad);
        transform.position = new Vector3(x, 0, z);
    }
}

