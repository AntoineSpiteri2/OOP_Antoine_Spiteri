using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameData : MonoBehaviour
{
    public Vector3 MousePos
    {
        get { return GetMousePos(); }
    }

    public float MinX
    {
        get { return GetMinX(); }
    }

    public float MaxX
    {
        get { return GetMaxX(); }
    }

    public float MaxY
    {
        get { return GetMaxY(); }
    }

    public float MinY
    {
        get { return GetMinY(); }
    }



    public static Vector3 GetMousePos()
    {
        Vector3 mousepoint3D = Camera.main.ScreenToWorldPoint(Input.mousePosition + Vector3.back * Camera.main.transform.position.z);
        return mousepoint3D;
    }


    public static float GetMinX()
    {
        float xmin;
        Camera mycamera = Camera.main;
        xmin = mycamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).x;
        return xmin;
    }

    public static float GetMaxX()
    {
        float xmax;
        Camera mycamera = Camera.main;
        xmax = mycamera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x;
        return xmax;
    }


    public static float GetMinY()
    {
        float Ymin;
        Camera mycamera = Camera.main;
        Ymin = mycamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).y;
        return Ymin;
    }


    public static float GetMaxY()
    {
        float Ymax;
        Camera mycamera = Camera.main;
        Ymax = mycamera.ViewportToWorldPoint(new Vector3(0, 1, 0)).y;
        return Ymax;
    }
}
