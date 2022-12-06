using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateText : MonoBehaviour
{

    private GameObject text;

    private void Start()
    {
        text = this.gameObject;
    }

    void Update()
    {
        text.GetComponent<Text>().text = GameData.Score.ToString();
    }
}
