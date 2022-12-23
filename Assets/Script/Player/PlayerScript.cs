using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    public float speed = 8f; 
    public GameObject player;

    public int health;
    public int numberOfPepo;
    private bool isDead;

    public CanvasScript gameManager;

    public Image[] pepos;

    void Update()
    {
        for (int i = 0; i < pepos.Length; i++)
        {
            if (i < numberOfPepo)
            {
                pepos[i].enabled = true;
            } 
            else
            {
                pepos[i].enabled = false;
            }
        }
        movement();
    }

    void movement() 
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector2 pos = transform.position;

        pos.x += h * speed * Time.deltaTime;
        pos.y += v * speed * Time.deltaTime;

        transform.position = pos;
    }


    public void Damage()
    {
        --health;
        --numberOfPepo;
        if (health <= 0 && isDead == false)
        {
            isDead = true;
            numberOfPepo = 0;
            // Destroy(player);
            gameObject.SetActive(false);
            gameManager.gameOver();
            Debug.Log("Dead");
        }
    }

}
