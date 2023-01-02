using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossUlt : MonoBehaviour
{
    public float damage;
    private bool isHit;
    public GameObject theUlt;
    private float CountDown = 5f;
    private float noCD = 0f;
    public float speed = 0.1f;
    private float scale = 10;
    Vector3 temp;

    void Update()
    {
        laserTime();
    }
    
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Player" && isHit == false)
        {
            isHit = true;
            for (int i = 0; i < damage; i++)
            {
                collision.gameObject.GetComponent<PlayerScript>().Damage();
            }

            if (Time.time > noCD)
            {
                noCD = Time.time + CountDown;
                isHit = false;
            }
        }
    }

    public void laserTime()
    {
        temp = transform.localScale;
        temp.x -= Time.deltaTime+speed;
        transform.localScale = temp;
        if (temp.x <= 0.2f)
        {
            Destroy(theUlt);
        }
    }
}
