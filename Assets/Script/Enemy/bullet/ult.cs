using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ult : MonoBehaviour
{
    public GameObject enemyBullet;
    public float damage;
    public float scale;
    public float speed;

    private bool hit = false;

    Vector3 temp;
    
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Player")
        {
            for (int i = 0; i < damage; i++)
            {
                collision.gameObject.GetComponent<PlayerScript>().Damage();
            }
            scaleUp();
            Destroy(enemyBullet, 0.5f);
        }
        if (collision.gameObject.tag == "Boundary")
        {
            scaleUp();
            Destroy(enemyBullet, 0.5f);
        }
    }

    void scaleUp()
    {
        if (hit == false)
        {
            for (int i = 0; i < scale; i++)
            {   
                temp = transform.localScale;
                temp.x += Time.deltaTime+speed;
                temp.y += Time.deltaTime+speed;
                transform.localScale = temp;
                hit = true;
            }
        }
                
    }
}
