using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player2 : MonoBehaviour
{
    PlayerControls controls2;
    Vector2 moveDirection;
    [SerializeField] private float speed;
    Rigidbody rb;

    private void Awake()
    {
        controls2 = new PlayerControls();
        rb = GetComponent<Rigidbody>();

        controls2.GamePlay.Movement1.performed += ctx => moveDirection = ctx.ReadValue<Vector2>();
        controls2.GamePlay.Movement1.canceled += ctx => moveDirection = Vector2.zero;
    }

    private void Update()
    {
        Vector2 m = new Vector2(moveDirection.x, moveDirection.y) * speed;
        rb.velocity = m;
    }

    private void OnEnable()
    {
        controls2.GamePlay.Enable();
    }

    private void OnDisable()
    {
        controls2.GamePlay.Disable();
    }
}