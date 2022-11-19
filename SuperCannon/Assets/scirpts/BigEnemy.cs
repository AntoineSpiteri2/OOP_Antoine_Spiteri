using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigEnemy : EnemyScirpt
{
    // Start is called before the first frame update
    protected override void Start()
    {
        Enspeed = UnityEngine.Random.Range(1f, 2.5f);
        dmg = 5;
        base.Start();
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }
}
