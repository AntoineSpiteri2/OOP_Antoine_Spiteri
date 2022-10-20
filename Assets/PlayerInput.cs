using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public GameObject prefab1, prefab2;
    public GameObject girl, tate;
    int playerHP = 10; //This is our hp
    void Start()
    {
        /*         bob = new Enemy(5, 2, "Bob");
                //Bob has 5 hp, 2 damage, and a name of Bob
                alice = new Enemy(2, 5, "Alice");
                //Alice has 2 hp, 5 damage, and a name of Alice */


        tate = Instantiate(tate, new Vector3(-3f, 0f, 0f), Quaternion.identity);

        girl = Instantiate(girl, new Vector3(3f, 0f, 0f), Quaternion.identity);

        tate.GetComponent<Enemy>().hitpoints = 5;
        tate.GetComponent<Enemy>().damage = 2;
        tate.GetComponent<Enemy>().name = "tate";

        girl.GetComponent<Enemy>().hitpoints = 2;
        girl.GetComponent<Enemy>().damage = 5;
        girl.GetComponent<Enemy>().name = "girl";

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            //Bob takes damage if Spacebar is pressed
            tate.GetComponent<Enemy>().TakeDamage();
        else if (Input.GetKeyDown(KeyCode.LeftShift))
            //Alice takes damage if left shift is pressed
            girl.GetComponent<Enemy>().TakeDamage();
        else if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            //Player takes damage from bob if left control is pressed
            playerHP -= tate.GetComponent<Enemy>().damage;
            Debug.Log("Player HP: " + playerHP);
        }
        else if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            //Player takes damage from alice if left alt is pressed
            playerHP -= girl.GetComponent<Enemy>().damage;
            Debug.Log("Player HP: " + playerHP);
        }
    }
}