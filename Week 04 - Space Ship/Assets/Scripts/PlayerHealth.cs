using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int maxHealth;
    [SerializeField] private int currentHealth;

    [SerializeField] private GameObject player;
    
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
            player.SetActive(false);
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