using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchoolVO : MonoBehaviour
{
    AudioSource schoolSound;
    // Start is called before the first frame update
    void Start()
    {
        schoolSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            schoolSound.Play();
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            schoolSound.Stop();
        }
    }
}
