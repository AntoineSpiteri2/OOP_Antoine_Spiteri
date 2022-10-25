using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chessChange : MonoBehaviour
{
    // Start is called before the first frame update


    public GameObject blackSquare;
    public GameObject whiteSquare;
    public static List<GameObject> Squares = new List<GameObject>();

    void Start()
    {
        Squares.Add(blackSquare);
        Squares.Add(whiteSquare);

        float xW = -14.5f;
        float xB = -13.5f;


        float y = 4.5f;



        for (int a = 0; a < 10; a++)
        {

            for (int i = 0; i < 10; i++)
            {

                Debug.Log(i);
                Instantiate(Squares[0], new Vector2(xB + i + i +a, y-a), Quaternion.identity);
                Instantiate(Squares[1], new Vector2(xW + i + i + a, y-a), Quaternion.identity);

                Instantiate(Squares[1], new Vector2(xW + i + i + a, y - a), Quaternion.identity);
                Instantiate(Squares[1], new Vector2(xW + i + i + a, y - a), Quaternion.identity);

                Instantiate(Squares[1], new Vector2(xW + i + i + a, y - a), Quaternion.identity);
                Instantiate(Squares[1], new Vector2(xW + i + i + a, y - a), Quaternion.identity);

                Instantiate(Squares[1], new Vector2(xW + i + i + a, y - a), Quaternion.identity);
                Instantiate(Squares[1], new Vector2(xW + i + i + a, y - a), Quaternion.identity);

                Instantiate(Squares[1], new Vector2(xW + i + i + a, y - a), Quaternion.identity);
                Instantiate(Squares[1], new Vector2(xW + i + i + a, y - a), Quaternion.identity);

            }

        }

    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            blackSquare.GetComponent<SpriteRenderer>().color =  new Color(1f, 0f, 1f, 0f);
            whiteSquare.GetComponent<SpriteRenderer>().color =  new Color(0f, 1f, 1f, 0f);
        }
    }
}
