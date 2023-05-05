using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkVO : MonoBehaviour
{
    AudioSource workSound;
    // Start is called before the first frame update
    void Start()
    {
        workSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            workSound.Play();
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            workSound.Stop();
        }
    }
}
