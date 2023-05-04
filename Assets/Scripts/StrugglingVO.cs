using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrugglingVO : MonoBehaviour
{
    AudioSource struggleSound;

    // Start is called before the first frame update
    void Start()
    {
        struggleSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            struggleSound.Play();
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            struggleSound.Stop();
        }
    }
}
