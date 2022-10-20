using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;
using Color = UnityEngine.Color;

public class Bouncer : MonoBehaviour
{

    public Vector2 velcoity = new Vector2(80f, 120f);
    public int health = 100;
    public float alpha = 1;
    Color currentcolor;

    public GameObject ball;


    // Start is called before the first frame update
    void Start()
    {

        GetComponent<Rigidbody2D>().velocity = velcoity * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        /* GetComponent<Transform>().position = transform.position + new Vector3( 0.1f, 0.1f, 0f);*/
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        health = health - 10;
        alpha = alpha - 0.1f;
        GetComponent<SpriteRenderer>().color = GetComponent<SpriteRenderer>().color - new Color(0f, 0f, 0f, 0.1f); ;


        Debug.Log(this.gameObject.name);
        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}


