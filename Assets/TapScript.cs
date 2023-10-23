using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapScript : MonoBehaviour
{
    // Start is called before the first frame update
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            audioSource.Play();
        }
    }
}
