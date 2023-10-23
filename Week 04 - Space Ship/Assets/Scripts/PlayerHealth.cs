using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int maxHealth;
    [SerializeField] private int currentHealth;

    [SerializeField] private GameObject player;
    public bool player1Dead = false;
    public bool player2Dead = false;

    public int id;
    
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void PlayerLife(int amount)
    {
        currentHealth -= amount;

        if (currentHealth <= 0.0f)
        {
            if(id == 1)
            {
                player1Dead = true;
                //Debug.Log("player 1 dead");
                player.SetActive(false);
                
            }
            else if (id == 2)
            {
                player2Dead = true;
                //Debug.Log("player 2 dead");
                player.SetActive(false);
            }
        }
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            PlayerLife(1);
        }

        if(collision.gameObject.tag == "Enemy Bullet")
        {
            PlayerLife(1);
        }
    }
}