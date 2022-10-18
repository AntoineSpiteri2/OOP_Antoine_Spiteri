using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class increase_bounce : MonoBehaviour
{


    Rigidbody2D mrid;
    // Start is called before the first frame update


    public PhysicsMaterial2D bounce;
    void Start()
    {

        bounce.bounciness = 1f;

       mrid = this.GetComponent<Rigidbody2D>();
       /* mrid.AddForce(Vector3.left * 500f);*/

    }

    private void Update()
    {

        Debug.Log(bounce.bounciness);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        mrid.AddForce(Vector3f);
        bounce.bounciness = bounce.bounciness + 1f;
    }
}
