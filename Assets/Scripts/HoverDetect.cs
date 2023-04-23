using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class HoverDetect : MonoBehaviour
{
    //public GameObject Inspection;
    //public InspectionObject inspectionObj;
    //public int index;
    // Start is called before the first frame update
  
    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (GetComponent<Collider>().Raycast(ray, out hit, 100f))
        {
            print("hover on" + gameObject.name);
            SceneManager.LoadScene("TV", LoadSceneMode.Single);
            if (Input.GetMouseButtonDown(0))
            {
                //Inspection.SetActive(true);
            }
        }
    }
}
