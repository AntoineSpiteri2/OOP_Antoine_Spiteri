using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    public Vector2 velcoity = new Vector2(80f, 120f);
    // Start is called before the first frame update
    void Start()
    {

        GetComponent<Rigidbody2D>().velocity = velcoity * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
       /* GetComponent<Transform>().position = transform.position + new Vector3( 0.1f, 0.1f, 0f);*/
    }
}
