using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroyOnBullets : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}