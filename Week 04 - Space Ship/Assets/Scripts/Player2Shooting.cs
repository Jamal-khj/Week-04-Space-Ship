using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Shooting : MonoBehaviour
{
    [SerializeField] private Transform shootingPoint;
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private float projectileForce;

    [SerializeField] private AudioSource shootingSoundEffect;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(projectilePrefab, shootingPoint.position, shootingPoint.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.AddForce(shootingPoint.up * projectileForce, ForceMode.Impulse);
        shootingSoundEffect.Play();
    }
}