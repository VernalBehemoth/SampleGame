using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class CharacterController : MonoBehaviour
{
    [SerializeField] private float speed = 2f;

    private Rigidbody2D _rigidbody2D;
    private float horizontalInput;
    private float verticalInput;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //Track player input on update for better responsivness
        horizontalInput = Input.GetAxisRaw("Horizontal"); 
        verticalInput = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        _rigidbody2D.velocity = new Vector2(horizontalInput * speed, verticalInput * speed);
    }
}
