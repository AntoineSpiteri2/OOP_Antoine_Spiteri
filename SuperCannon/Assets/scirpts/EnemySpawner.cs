using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{


    public static EnemySpawner _instance;

    public List<enemy> enemylist;




    //singleton basically destorys duplicates thus prevents furture bugs first method
    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        else if (_instance !=this)
        {
            Destroy(this.gameObject);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnEnemies()
    {
        while (true)
        {
            int enemychoice = Random.Range(0, enemylist.Count);
            Instantiate(enemylist[enemychoice].enemyGO, new Vector3(Random.Range(GameData.GetMinX(), GameData.GetMaxX()), GameData.GetMaxY(), 0), Quaternion.identity);
            yield return new WaitForSeconds(1);
        }

    }

}
