using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossUlt : MonoBehaviour
{
    public GameObject enemyBullet;
    public float damage;

    private bool isHit;

    public UltGun gun;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Player" && isHit == false)
        {
            isHit = true;
            for (int i = 0; i < damage; i++)
            {
                collision.gameObject.GetComponent<PlayerScript>().Damage();
            }
            damageCooldown();
            Destroy(enemyBullet, 10f);
            // gun.despawn();
        }
        
    }

    IEnumerator damageCooldown()
    {
        yield return new WaitForSeconds(1f);
        isHit = false;
        Debug.Log("damecooldoiwn");
    }
}
