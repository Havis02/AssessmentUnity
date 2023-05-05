using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WardrobeHover : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (GetComponent<Collider>().Raycast(ray, out hit, 2f))
        {
            print("hover on" + gameObject.name);

            GameObject player = GameObject.FindGameObjectWithTag("Player");
            ReloadPosition.setPosition(player.transform.position, player.transform.rotation);

            SceneManager.LoadScene("Wardrobe", LoadSceneMode.Single);


            if (Input.GetMouseButtonDown(0))
            {
                //Inspection.SetActive(true);
            }
        }
    }
}
