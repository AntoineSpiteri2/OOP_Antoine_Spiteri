using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameData : MonoBehaviour
{
    public Vector3 MousePos
    {
        get { return GetMousePos(); }
    }
    private static Vector3 GetMousePos()
    {
        Vector3 mousepoint3D = Camera.main.ScreenToWorldPoint(Input.mousePosition + Vector3.back * Camera.main.transform.position.z);
        return mousepoint3D;
    }
}
