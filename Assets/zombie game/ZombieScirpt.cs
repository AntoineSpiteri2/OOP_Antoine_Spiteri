using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class ZombieScirpt : MonoBehaviour
{

    public GameObject player;

    Transform playerpos;


    private void Start()
    {
        playerpos = player.transform;
    }




    private void Update()
    {



        /* Vector2.MoveTowards(transform.position, playerpos); */
    }







}
