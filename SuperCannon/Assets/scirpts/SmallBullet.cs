using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallBullet : bullet
{
    // Start is called before the first frame update
    protected override void Start()
    {
        speed = 10f;
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
