using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class bullet : MonoBehaviour
{
    [SerializeField] protected float speed = 5;
    Vector3 mousePoint3D;
    // Start is called before the first frame update
    protected virtual void Start()
    {
        mousePoint3D = GameData.GetMousePos();
        Vector2 direction = new Vector2(mousePoint3D.x, mousePoint3D.y + 5f);
        direction.Normalize();
        GetComponent<Rigidbody2D>().velocity = direction * speed;
    }


    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }

}
