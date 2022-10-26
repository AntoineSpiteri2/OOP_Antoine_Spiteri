using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class largebullet : bullet
{
    // Start is called before the first frame update
    protected virtual void Start()
    {
        speed = 2;
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
        transform.Translate(speed * Time.deltaTime, 0f, 0f);
    }
}