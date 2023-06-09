using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadingVO : MonoBehaviour
{
    AudioSource readingSound;
    // Start is called before the first frame update
    void Start()
    {
        readingSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            readingSound.Play();
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            readingSound.Stop();
        }
    }
}

