using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class Player1Shooting : MonoBehaviour
{
    [SerializeField] private Transform shootingPoint;
    [SerializeField] private GameObject projectilePrefab;
    PlayerControls controls1;

    private void Awake()
    {
        controls1 = new PlayerControls();

        controls1.GamePlay.Shooting.performed += _ => shooting();
    }

    void shooting()
    {
        Instantiate(projectilePrefab, shootingPoint.position, transform.rotation);
    }
}