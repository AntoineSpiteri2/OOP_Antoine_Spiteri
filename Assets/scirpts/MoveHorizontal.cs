using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MoveVertical))]
public class MoveHorizontal : MonoBehaviour
{


    [SerializeField] float xspeed, vspeedchange = 0;


    MoveVertical myVmove;

    void Start()
    {
        /* xspeed = 1; */
        myVmove = GetComponent<MoveVertical>();
    }

    // Update is called once per frame
    void Update()
    {
        myVmove.yspeed = myVmove.yspeed - vspeedchange;
        transform.Translate(xspeed * Time.deltaTime, 0f, 0f);
    }
}
