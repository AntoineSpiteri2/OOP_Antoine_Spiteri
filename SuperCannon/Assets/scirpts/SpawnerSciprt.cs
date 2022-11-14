using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.ConstrainedExecution;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;
using static UnityEngine.GraphicsBuffer;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class SpawnerSciprt : MonoBehaviour
{

    public GameObject enemy;
    public GameObject player;
    public float speed = 40f;
    float nextSpawn = 0.0f;




    public float ran;
    // Start is called before the first frame update
    void Start()
    {
        ran = UnityEngine.Random.Range(1f, 3f);


    }

    // Update is called once per frame
    void Update()
    {
        SpawnEnemy();
        Move();
    }

    void Move()
    {
        transform.RotateAround(player.transform.position, Vector3.forward, speed * Time.deltaTime);
    }


    void SpawnEnemy()
    {


        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + ran;

            Vector3 pos = new Vector3(transform.position.x, transform.position.y, 0);

            if (gameObject.transform.position.y > 0)
            {
                Instantiate(enemy, pos, Quaternion.identity);
            } else
            {
                ran = UnityEngine.Random.Range(1f, 3f);
                speed = UnityEngine.Random.Range(10f, 40f);
            }

        }
    }
}
