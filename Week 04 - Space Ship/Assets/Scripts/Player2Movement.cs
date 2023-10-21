using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody rb;

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(vertical * speed, rb.velocity.y);
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.x);
    }
}