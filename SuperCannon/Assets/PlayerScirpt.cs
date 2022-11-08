using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScirpt : MonoBehaviour
{
    public int health = 50;


    private void OnCollisionEnter2D(Collision2D collision)
    {

        Destroy(collision.gameObject);

    }

}
