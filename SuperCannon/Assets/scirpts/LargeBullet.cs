using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LargeBullet : bullet
{
    // Start is called before the first frame update
    protected override void OnEnable()
    {
        speed = 12.5f;
        GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        GetComponent<Rigidbody2D>().gravityScale = 1;
        base.OnEnable();
    }


}
