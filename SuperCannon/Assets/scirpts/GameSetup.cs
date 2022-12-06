using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetup : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Hwall;

    public GameObject Vwall;

    void Start()
    {

        Instantiate(Hwall, new Vector3(0,GameData.YMin - 8f, 0), Quaternion.Euler(new Vector3(0, 0, 90)));
        Instantiate(Hwall, new Vector3(0, GameData.YMax + 8f, 0), Quaternion.Euler(new Vector3(0, 0, 90)));
        Instantiate(Vwall, new Vector3(GameData.XMin - 8f, 0, 0), Quaternion.identity);
        Instantiate(Vwall, new Vector3(GameData.XMax+ 8f, 0, 0), Quaternion.identity);
    }

}
