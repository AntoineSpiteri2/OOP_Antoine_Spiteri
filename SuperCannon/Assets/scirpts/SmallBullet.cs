using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallBullet : bullet
{
    // Start is called before the first frame update
    protected override void OnEnable()
    {
        speed = 10f;
        base.OnEnable();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
