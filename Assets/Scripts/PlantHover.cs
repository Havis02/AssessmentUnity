using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlantHover : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (GetComponent<Collider>().Raycast(ray, out hit, 100f))
        {
            print("hover on" + gameObject.name);
            SceneManager.LoadScene("PlantAlive", LoadSceneMode.Single);
            if (Input.GetMouseButtonDown(0))
            {
                //Inspection.SetActive(true);
            }
        }
    }
}
