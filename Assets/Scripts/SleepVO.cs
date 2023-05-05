using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleepVO : MonoBehaviour
{
    AudioSource sleepSound;
    // Start is called before the first frame update
    void Start()
    {
        sleepSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            sleepSound.Play();
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            sleepSound.Stop();
        }
    }
}
