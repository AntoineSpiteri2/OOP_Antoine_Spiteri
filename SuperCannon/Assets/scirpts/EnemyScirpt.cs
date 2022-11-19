using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class EnemyScirpt : MonoBehaviour
{

    [SerializeField] protected float Enspeed;
    public GameObject player;
    [SerializeField] protected int dmg = 5;

    // Start is called before the first frame update
    protected virtual void Start()
    {
    }

    // Update is called once per frame
    protected virtual void Update()
    {

        float step = Enspeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, step);

    }




}
