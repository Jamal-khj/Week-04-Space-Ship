using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    PlayerControls controls;
    Vector2 moveDirection;

    private void Awake()
    {
        controls = new PlayerControls();

        controls.GamePlay.Movement.performed += ctx => moveDirection = ctx.ReadValue<Vector2>();
        controls.GamePlay.Movement.canceled += ctx => moveDirection = Vector2.zero;
    }

    private void Update()
    {
        Vector2 m = new Vector2(moveDirection.x, moveDirection.y) * Time.deltaTime;
        transform.Translate(m, Space.World);
    }

    private void OnEnable()
    {
        controls.GamePlay.Enable();
    }
}