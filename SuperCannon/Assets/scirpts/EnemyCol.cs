using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SocialPlatforms.Impl;

public class EnemyCol : MonoBehaviour
{


    [SerializeField] enemy enemys;

    int score;


    


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

        Colliders.gameObject.SetActive(false);
        enemys.health = enemys.strength - enemys.health;
        enemys.speed--;

        if (enemys.health <= 0)
        {
            Debug.Log(FindObjectOfType<GameData>().GameScore())
            Destroy(this.gameObject);
        }
    }


}
