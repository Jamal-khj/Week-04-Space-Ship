using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int maxLife;
    [SerializeField] private int currentLife;

    [SerializeField] private float respawnTimer;
    [SerializeField] private float fixedTimer;
    [SerializeField] private GameObject player;
    [SerializeField] private Transform respawnLocation;
    
    // Start is called before the first frame update
    void Start()
    {
        currentLife = maxLife;
    }

    public void PlayerLife(int amount)
    {
        currentLife -= amount;

        Destroy(gameObject);

        if (currentLife > 0.0f)
        {
            respawnTimer -= Time.deltaTime;
            if (respawnTimer <= 0.0f)
            {
                respawnTimer = fixedTimer;
                Instantiate(player, respawnLocation.position, respawnLocation.rotation);
            }
        }
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            PlayerLife(1);
        }
    }
}