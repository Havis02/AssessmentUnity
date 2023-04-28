using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ReloadPosition
{
    public static Vector3 position;
    public static Quaternion rotation;
    public static bool positionSet = false;

    //Update is called once per frame
    public static void setPosition(Vector3 pos, Quaternion rot)
    {
        Debug.Log("setpos");

        position = pos;
        rotation = rot;
        positionSet = true;


    }
}
