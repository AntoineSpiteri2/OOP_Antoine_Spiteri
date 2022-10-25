using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class soilder : MonoBehaviour
{


    public GameObject myplayer;
    // Start is called before the first frame update


    public float xmin, xmax, ymin, ymax;


    public float speed = 10f;

    public float padding = 0.1f;

    Rigidbody2D myRigidbody;

    Vector2 myPosition;



    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();

        Camera mycamera = Camera.main;
        xmin = mycamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).x * padding;
        ymin = mycamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).y * padding;
        xmax = mycamera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x * padding;
        ymax = mycamera.ViewportToWorldPoint(new Vector3(0, 1, 0)).y * padding;


    }



    // Update is called once per frame

    void Update()
    {

 
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, xmin, xmax), Mathf.Clamp(transform.position.y, ymin, ymax));
        myRigidbody.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed); //< -----doesnt really work well with deltatime but use fixedupdate to sort of fix that


        /*if (Input.GetKey(KeyCode.A))
        {
            myPosition = new Vector2(-speed * Time.deltaTime, 0);
            myRigidbody.AddForce(myPosition, 0);
        } else if (Input.GetKey(KeyCode.D)) 
        {
            myPosition = new Vector2(speed*Time.deltaTime, 0);
            myRigidbody.AddForce(myPosition, 0);
        } else if (Input.GetKey(KeyCode.W))
        {
            myPosition = new Vector2(0, speed * Time.deltaTime);
            myRigidbody.AddForce(myPosition, 0);
        } else if (Input.GetKey(KeyCode.S))
        {
            myPosition = new Vector2(0, -speed * Time.deltaTime);
            myRigidbody.AddForce(myPosition, 0);
        }*/



    }



}


