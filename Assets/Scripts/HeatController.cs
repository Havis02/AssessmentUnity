using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeatController : MonoBehaviour
{
    public ParticleSystem heat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            heat.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            heat.Stop();
        }
    }
}
