using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerGun : MonoBehaviour
{
    public GameObject gun;
    public GameObject normalBullet;
    public GameObject normalBulletClone;
    private float delay = 0;
    public float bulletCooldown;


    void Update()
    {
        normalFire();
    }

    void normalFire()
    {
        if (Input.GetKey(KeyCode.Space) && delay > bulletCooldown)
        {
            normalBulletClone = Instantiate(normalBullet, new Vector3(gun.transform.position.x,gun.transform.position.y,0), transform.rotation) as GameObject;
            delay = 0;
        } else
        {
            delay++;
        } 
    }
}
