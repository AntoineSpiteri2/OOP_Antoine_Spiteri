using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public int hitpoints, damage;
    public string EnemyName;
    /*     public Enemy(int hp, int dmg, string ID)
        { //this constructor assigns hitpoints, damage, and name to
          //the values passed into the constructor
            hitpoints = hp;
            damage = dmg;
            EnemyName = ID;
        } */

    void Awake()
    {

    }
    public void TakeDamage()
    {
        hitpoints--; //reduce HP by 1
        GetComponent<SpriteRenderer>().color = GetComponent<SpriteRenderer>().color - new Color(0.1f, 0.2f, 0.6f, 1f);
        Debug.Log(EnemyName + "'s HP: " + hitpoints); //print out new hp
    }
    public void Die()
    {
        Debug.Log(EnemyName + " Has Died"); //print to the console
    }

}
