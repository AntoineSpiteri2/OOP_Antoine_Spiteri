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
    public GameObject enemy2;
    public GameObject player;
    public float speed = 100f;
    float nextSpawn = 0.0f;
    bool A = true;




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

        if (gameObject.transform.position.y < 0)
        {
            gameObject.transform.position = new Vector3(40, 0, 0);
            speed = UnityEngine.Random.Range(40f, 200f);

        }
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

            if (A == true)
            {
                Instantiate(enemy, pos, Quaternion.identity);
                ran = UnityEngine.Random.Range(2.5f, 5f);
                A = false;
            } else if (A == false)
            {
                Instantiate(enemy2, pos, Quaternion.identity);
                ran = UnityEngine.Random.Range(2.5f, 5f);
                A = true; 
            }



        }
    }
}
