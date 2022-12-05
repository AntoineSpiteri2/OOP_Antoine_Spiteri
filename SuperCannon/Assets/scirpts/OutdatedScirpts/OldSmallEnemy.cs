using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallEnemy : EnemyScirpt
{
    // Start is called before the first frame update
    protected override void Start()
    {
        Enspeed = UnityEngine.Random.Range(5f, 7f);
        dmg = 2;
        score = 5;
        base.Start();
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }
}
