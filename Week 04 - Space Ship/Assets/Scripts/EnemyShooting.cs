using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    [SerializeField] private Transform shootingPoint;
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private float projectileForce;
    [SerializeField] private float shootingTimer;
    [SerializeField] private float fixedShootingTimer;

    private void Start()
    {
        shootingTimer = fixedShootingTimer;
    }

    // Update is called once per frame
    void Update()
    {
        shootingTimer -= Time.deltaTime;

        if(shootingTimer <= 0)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(projectilePrefab, shootingPoint.position, shootingPoint.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.AddForce(shootingPoint.up * projectileForce, ForceMode.Impulse);
        shootingTimer = fixedShootingTimer;
       // shootingSoundEffect.Play();
    }
}