using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputv2 : MonoBehaviour
{
    public GameObject prefab1, prefab2;
    GameObject tate, girl;
    int playerHP = 10; //This is our hp

    void Start()
    {
        tate = Instantiate(prefab1, new Vector3(-3f, 0f, 0f), Quaternion.identity);
        girl = Instantiate(prefab2, new Vector3(3f, 0f, 0f), Quaternion.identity);

        tate.GetComponent<Enemyv2>().hitpoints = 5;
        tate.GetComponent<Enemyv2>().damage = 2; 
        tate.GetComponent<Enemyv2>().enemyname = "tate";


        girl.GetComponent<Enemyv2>().hitpoints = 2;
        girl.GetComponent<Enemyv2>().damage = 5;
        girl.GetComponent<Enemyv2>().enemyname = "girl";

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("hello");

            //Bob takes damage if Spacebar is pressed
            tate.GetComponent<Enemyv2>().TakeDamage();   
        }
        else if (Input.GetKeyDown(KeyCode.LeftShift))
        {


            //Alice takes damage if left shift is pressed
            girl.GetComponent<Enemyv2>().TakeDamage();
        }
        else if (Input.GetKeyDown(KeyCode.LeftControl)) 
        {
            //Player takes damage from bob if left control is pressed
            playerHP -= tate.GetComponent<Enemyv2>().damage;
            Debug.Log("Player HP: " + playerHP);
        }
        else if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            //Player takes damage from alice if left alt is pressed
            playerHP -= girl.GetComponent<Enemyv2>().damage;
            Debug.Log("Player HP: " + playerHP);
        }

        if (tate.GetComponent<Enemyv2>().hitpoints < 1)
        {


            //if bob's hp is under 1, he dies
            tate.GetComponent<Enemyv2>().Die();
        }

        if (girl.GetComponent<Enemyv2>().hitpoints < 1)
        {
            //if alice's hp is under 1, she dies
            girl.GetComponent<Enemyv2>().Die();
        }


        if (playerHP < 1)
        {
            //if our hp is under 1, we die
            Debug.Log("You Died!");
        }
    }
}