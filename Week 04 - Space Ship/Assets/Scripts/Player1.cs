using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player1 : MonoBehaviour
{
    PlayerControls controls1;
    Vector2 moveDirection;
    [SerializeField] private float speed;
    Rigidbody rb;

    private void Awake()
    {
        controls1 = new PlayerControls();
        rb = GetComponent<Rigidbody>();

        controls1.GamePlay.Movement1.performed += ctx => moveDirection = ctx.ReadValue<Vector2>();
        controls1.GamePlay.Movement1.canceled += ctx => moveDirection = Vector2.zero;
    }

    private void Update()
    {
        Vector2 m = new Vector2(moveDirection.x, moveDirection.y) * speed;
        rb.velocity = m;
    }

    private void OnEnable()
    {
        controls1.GamePlay.Enable();
    }

    private void OnDisable()
    {
        controls1.GamePlay.Disable();
    }
}