using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SocialPlatforms.Impl;

public class EnemyCol : MonoBehaviour
{


    public int Starthealth, GameScore;
    private int health;

    


    void Start()
    {
        health = Starthealth;
    }





    private void OnTriggerEnter2D(Collider2D Collider)
    {

        TakeDmg(Collider);
    }


    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }



    public void TakeDmg(Collider2D Colliders)
    {
        if (Colliders.gameObject.name.Contains("bullet"))
        {
            Colliders.gameObject.SetActive(false);
            health--;
            Debug.Log("Enenmy health " + health.ToString());

            if (health <= 0)
            {
                
                GameData.Score += GameScore;
                Debug.Log("GameScore: " + GameData.Score.ToString());
                Destroy(this.gameObject);
            }
        }

    }


}
