using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnerSciprt : MonoBehaviour
{

    public GameObject enemy;
    float nextSpawn = 0.0f;

    public float ran;
    // Start is called before the first frame update
    void Start()
    {
        ran = UnityEngine.Random.Range(1f, 15f);
    }

    // Update is called once per frame
    void Update()
    {
        SpawnEnemy();
    }

    void SpawnEnemy()
    {


        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + ran;

            Vector3 pos = new Vector3(transform.position.x, transform.position.y, 0);

            Instantiate(enemy, pos, Quaternion.identity);

        }
    }
}
