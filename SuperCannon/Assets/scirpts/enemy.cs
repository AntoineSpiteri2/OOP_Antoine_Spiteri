using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "scriptableobjects/enemyscriptableobject", order = 1)]
public class enemy : ScriptableObject
{

    public GameObject enemyGO;
    public int scorevalue, strength, health;
    public float speed;


 


}
