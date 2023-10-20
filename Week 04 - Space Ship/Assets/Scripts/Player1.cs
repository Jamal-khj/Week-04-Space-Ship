using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player1 : MonoBehaviour
{
    PlayerControls controls;
    Vector2 moveDirection;
    [SerializeField] private float speed;
    Rigidbody rb;

    private void Awake()
    {
        controls = new PlayerControls();
        rb = GetComponent<Rigidbody>();

        controls.GamePlay.Movement1.performed += ctx => moveDirection = ctx.ReadValue<Vector2>();
        controls.GamePlay.Movement1.canceled += ctx => moveDirection = Vector2.zero;
    }

    private void Update()
    {
        Vector2 m = new Vector2(moveDirection.x, moveDirection.y) * speed;
        rb.velocity = m;
    }

    private void OnEnable()
    {
        controls.GamePlay.Enable();
    }

    private void OnDisable()
    {
        controls.GamePlay.Disable();
    }
}