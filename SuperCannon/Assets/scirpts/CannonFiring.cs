using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonFiring : MonoBehaviour
{
    // Start is called before the first frame update


    public void cannonfire(GameObject mybullet)
    {
        if (mybullet != null)
        {
            mybullet.transform.position = this.transform.position;
            mybullet.SetActive(true);
        }
    }
}
