using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetupGame : MonoBehaviour
{

    float xmin, ymin, xmax, ymax;
    public GameObject verticalwall, horizwall;

    public GameObject verticalwallT, horizwallT;
    public float padding = 0.5f;

    // Start is called before the first frame update
    void Start()
    {

        Camera mycamera = Camera.main;
        xmin = mycamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).x;
        ymin = mycamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).y;
        xmax = mycamera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x;
        ymax = mycamera.ViewportToWorldPoint(new Vector3(0, 1, 0)).y;

        float xmid = xmin + (xmax - xmin) / 2;
        float ymid = ymin + (ymax - ymin) / 2;

        Instantiate(horizwall, new Vector3(xmid, ymin, 0), Quaternion.identity);
        Instantiate(horizwall, new Vector3(xmid, ymax, 0), Quaternion.identity);
        Instantiate(verticalwall, new Vector3(xmin, ymid, 0), verticalwall.transform.rotation);
        Instantiate(verticalwall, new Vector3(xmax, ymid, 0), verticalwall.transform.rotation);


        Instantiate(horizwallT, new Vector3(xmid, ymin+0.1f, 0), Quaternion.identity);
        Instantiate(horizwallT, new Vector3(xmid, ymax + 0.1f, 0), Quaternion.identity);
        Instantiate(verticalwallT, new Vector3(xmin + 0.1f , ymid, 0), verticalwallT.transform.rotation);
        Instantiate(verticalwallT, new Vector3(xmax + 0.1f, ymid, 0), verticalwallT.transform.rotation);

    }



}
