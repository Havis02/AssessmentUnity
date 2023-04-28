using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountdownTimer : MonoBehaviour
{
    public float TimeRemaining;
    // Start is called before the first frame update
    void Start()
    {
        TimeRemaining = 10f;

    }

    // Update is called once per frame
    void Update()
    {
       if (TimeRemaining > 0)
        {
            TimeRemaining -= Time.deltaTime;
        }
       else
        {
            Debug.Log("Time is Up!");
        }
    }
}
