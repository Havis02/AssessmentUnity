using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

        
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (ReloadPosition.positionSet)
        {
            player.transform.position = ReloadPosition.position;
            // player.transform.rotation = ReloadPosition.rotation;


        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
