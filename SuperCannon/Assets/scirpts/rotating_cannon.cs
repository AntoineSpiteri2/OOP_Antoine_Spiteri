using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class rotating_cannon : MonoBehaviour
{

    Vector3 mousepoint3D;
    Quaternion newr;
    Quaternion clmapl, clmaph;

    public Transform FirePos;

    public GameObject bulletprefab;
    public GameObject bulletprefab2;
    // Start is called before the first frame update
    void Start()
    {
        clmapl = Quaternion.Euler(0, 0, -70);
        clmaph = Quaternion.Euler(0, 0, 70);
    }

    // Update is called once per frame
    void Update()
    {
        pointAtMouse();
        BulletFiring();
    }


    void pointAtMouse()
    {
        mousepoint3D = GameData.GetMousePos();
        newr = Quaternion.LookRotation(transform.position - mousepoint3D, Vector3.forward);
        newr.x = 0;
        newr.y = 0;

        newr.z = Mathf.Clamp(newr.z, clmapl.z, clmaph.z);
        newr.w = Mathf.Clamp(newr.w, clmapl.w, clmaph.w);
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, newr, Time.deltaTime);
        this.transform.rotation = newr;
    }

    void BulletFiring()
    {
        if (CrossPlatformInputManager.GetButtonDown("Fire1"))
        {
            /*             Instantiate(bulletprefab, FirePos.transform.position, Quaternion.identity);
             */
            Instantiate(bulletprefab, transform.GetChild(0).position, Quaternion.identity);

        }

        if (CrossPlatformInputManager.GetButtonDown("Fire2"))
        {
            /*             Instantiate(bulletprefab, FirePos.transform.position, Quaternion.identity);
             */
            Instantiate(bulletprefab2, transform.GetChild(0).position, Quaternion.identity);

        }



    }
}

