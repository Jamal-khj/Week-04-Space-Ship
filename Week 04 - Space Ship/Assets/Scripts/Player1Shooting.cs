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
    [SerializeField] private float projecticleForce = 20.0f;

    private void Awake()
    {
        controls1 = new PlayerControls();
    }

    private void Update()
    {
        controls1.GamePlay.Shooting.performed += cxt => shooting();
    }

    void shooting()
    {
        GameObject bullet = Instantiate(projectilePrefab, shootingPoint.position, shootingPoint.rotation);
    }

    private void OnEnable()
    {
        controls1.GamePlay.Enable();
    }
}