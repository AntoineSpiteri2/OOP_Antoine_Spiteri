using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHorizontal : MonoBehaviour
{


    
    float movespeed;



    // Start is called before the first frame update
    void Start()
    {
        movespeed = GetComponent<MoveVertical>().speed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(movespeed * Time.deltaTime, 0f, 0f);
    }
}
