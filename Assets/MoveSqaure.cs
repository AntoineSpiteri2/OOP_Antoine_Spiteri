using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSqaure : MonoBehaviour
{

     GameObject Myplayer;
    public GameObject myprefab;

    float xmin, ymin, xmax, ymax, newxpos, newypos;
    public float padding = 1F;

    // Start is called before the first frame update
    void Start()
    {
        Camera mycamera = Camera.main;
        xmin = mycamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).x + padding;
        ymin = mycamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).y + padding;
        xmax = mycamera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x + padding;
        ymax = mycamera.ViewportToWorldPoint(new Vector3(0, 1, 0)).y + padding;


        Myplayer = Instantiate(myprefab, new Vector3(0f, 0f, 0f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            newxpos = Mathf.Clamp(Myplayer.transform.position.x - 1, xmin, xmax);
            Myplayer.transform.position = new Vector3(newxpos, Myplayer.transform.position.y, 0f);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            newxpos = Mathf.Clamp(Myplayer.transform.position.x + 1, xmin, xmax);
            Myplayer.transform.position = new Vector3(newxpos, Myplayer.transform.position.y, 0f);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            newypos = Mathf.Clamp(Myplayer.transform.position.y + 1, ymin, ymax);
            Myplayer.transform.position = new Vector3(newypos, Myplayer.transform.position.x, 0f);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            newypos = Mathf.Clamp(Myplayer.transform.position.y - 1, ymin, ymax);
            Myplayer.transform.position = new Vector3(newypos, Myplayer.transform.position.x, 0f);
        }
    }
}
