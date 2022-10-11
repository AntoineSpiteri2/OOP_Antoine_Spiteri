using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBallsAtCorner : MonoBehaviour
{
    // Start is called before the first frame update

    float xmin, ymin, xmax, ymax;
    public GameObject myprefab;
    public float padding = 0.5F;

    void Start()
    {
        Camera mycamera = Camera.main;
        xmin = mycamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).x;
        ymin = mycamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).y;
        xmax = mycamera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x;
        ymax = mycamera.ViewportToWorldPoint(new Vector3(0, 1, 0)).y;

        Debug.Log("Xmin: " + xmin.ToString());
        Debug.Log("Xmin: " + ymin.ToString());
        Debug.Log("Xmin: " + xmax.ToString());
        Debug.Log("Xmin: " + ymax.ToString());

        Instantiate(myprefab, new Vector3(xmin + padding, ymin + padding, 0), Quaternion.identity);
        Instantiate(myprefab, new Vector3(xmin + padding, ymax - padding, 0), Quaternion.identity);
        Instantiate(myprefab, new Vector3(xmax - padding, ymin + padding, 0), Quaternion.identity);
        Instantiate(myprefab, new Vector3(xmax - padding, ymax - padding, 0), Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
