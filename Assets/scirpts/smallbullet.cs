using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smallbullet : bullet
{
    // Start is called before the first frame update
    protected virtual void Start()
    {
        speed = 5;
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }
}
