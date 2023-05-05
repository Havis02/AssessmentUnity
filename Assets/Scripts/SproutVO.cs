using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SproutVO : MonoBehaviour
{
    AudioSource plantSound;
    // Start is called before the first frame update
    void Start()
    {
        plantSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            plantSound.Play();
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            plantSound.Stop();
        }
    }
}


