using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


public class Rotating_Cannon : MonoBehaviour
{
    Vector3 mousePoint3D;
    Quaternion newrotation;

    Quaternion clampRotationLow, clampRotationHigh;

    public ObjectPool Bullet1pool, Bullet2pool;
  //  public Transform fireposition;
    // Start is called before the first frame update
    void Start()
    {
        clampRotationLow = Quaternion.Euler(0, 0, -70);
        clampRotationHigh = Quaternion.Euler(0, 0, 70);
    }

    // Update is called once per frame
    void Update()
    {
        PointAtMouse();
        BulletFiring();
    }

    void PointAtMouse()
    {
        mousePoint3D = GameData.GetMousePos();
        newrotation = Quaternion.LookRotation(transform.position - mousePoint3D, Vector3.forward);
        newrotation.x = 0;
        newrotation.y = 0;
        newrotation.z = Mathf.Clamp(newrotation.z, clampRotationLow.z, clampRotationHigh.z);
        newrotation.w = Mathf.Clamp(newrotation.w, clampRotationLow.w, clampRotationHigh.w);
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, newrotation, Time.deltaTime * 3f);
        //this.transform.rotation = newrotation;
    }


    void BulletFiring()
    {
        if (CrossPlatformInputManager.GetButtonDown("Fire1"))
        {
            GameObject smallbullet = Bullet1pool.GetComponent<ObjectPool>().GetPooledObject();
            if (smallbullet!=null)
            {
                smallbullet.transform.position = this.gameObject.transform.GetChild(0).position;
                smallbullet.SetActive(true);
            }
           // Instantiate(bullet1prefab, this.gameObject.transform.GetChild(0).position, Quaternion.identity);
        }

        if (CrossPlatformInputManager.GetButtonDown("Fire2"))
        {
            GameObject largebullet = Bullet2pool.GetComponent<ObjectPool>().GetPooledObject();
            if (largebullet != null)
            {
                largebullet.transform.position = this.gameObject.transform.GetChild(0).position;
                largebullet.SetActive(true);
            } 
            /*Instantiate(bullet2prefab, this.gameObject.transform.GetChild(0).position, Quaternion.identity);*/
        }

    }


}
