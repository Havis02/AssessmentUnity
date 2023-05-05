using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
    public float TimeRemaining;
    // Start is called before the first frame update
    void Start()
    {
        TimeRemaining = 30f;

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
            SceneManager.LoadScene("EndScreen", LoadSceneMode.Single);
            if (Input.GetMouseButtonDown(0))
            {

            }
        }
    }
}
