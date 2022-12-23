using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyUlt : MonoBehaviour
{
    public float speed = 1f;
    public GameObject firstBullet;

    public GameObject secondBullet;
    public GameObject secondBulletClone;

    void Update()
    {
        transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
    }
    
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Boundary")
        {
            secondBulletClone = Instantiate(secondBullet, new Vector3(firstBullet.transform.position.x,firstBullet.transform.position.y,0), transform.rotation) as GameObject;
            Destroy(firstBullet);
        } 
        if (collision.gameObject.tag == "BulletEnd") {
            Destroy(firstBullet);
        }
    }
}
