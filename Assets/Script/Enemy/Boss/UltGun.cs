using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UltGun : MonoBehaviour
{
    public float likelyhood;

    public GameObject enemy1Bullet;
    public GameObject enemy1BulletClone;
    public GameObject gun;

    private bool isSpawn;

    void Update()
    {
        shoot();
    }

    public void shoot()
    {
        if (Random.Range(0f, likelyhood) < 1 && isSpawn == false)
        {
            isSpawn = true;
            enemy1BulletClone = Instantiate(enemy1Bullet, new Vector3(gun.transform.position.x,gun.transform.position.y - 0,0), transform.rotation) as GameObject;
        }
    }

    public void despawn()
    {
        isSpawn = false;
    }
}
