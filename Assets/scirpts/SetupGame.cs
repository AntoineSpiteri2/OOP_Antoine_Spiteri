using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetupGame : MonoBehaviour
{
    // Start is called before the first frame update
    float xmin, ymin, xmax, ymax;
    public float padding = 0.5F;
    void Start()
    {

        Camera mycamera = Camera.main;
        xmin = mycamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).x;
        ymin = mycamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).y;
        xmax = mycamera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x;
        ymax = mycamera.ViewportToWorldPoint(new Vector3(0, 1, 0)).y;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
