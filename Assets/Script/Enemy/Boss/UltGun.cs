using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UltGun : MonoBehaviour
{
    public GameObject theUlt;

    public int likelyhood;
    public float lifeTime;
    private float lastSpawn;   

    private float CountDown = 5f;
    private float noCD;

    public GameObject gun;

    private bool isSpawn = false;


    void Update()
    {
        shot();
    }

    public void shot()
    {
        if (Random.Range(0f, likelyhood) < 1 && isSpawn == false)
        {
            Debug.Log("active true");
            theUlt.SetActive(true);
            isSpawn = true;
            noCD = Time.time + CountDown;

            if (Time.time > noCD)
            {
                noCD = Time.time + CountDown;
                theUlt.SetActive(false);
                isSpawn = false;
                Debug.Log("active false");
            }
        }
    }
}
