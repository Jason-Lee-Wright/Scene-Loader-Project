using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    // Get a reference to the Character Controller
    public Rigidbody2D RigidBody;

    // The speed the player will move, and made visible in the inspector
    [SerializeField]
    private float MoveSpeed = 5.0f;

    private Vector2 currentMoveDirection = Vector2.zero; // Store the current move direction

    void Start()
    {
        // actually collectiong the Character controller attached to the player
        RigidBody = this.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        // Move each frame a button is held dwon
        HandleMovement();
    }

    void UpdateMoveDirection(Vector2 InputVector)
    {
        // Update the current move direction when the event is triggered
        currentMoveDirection = InputVector;
    }

    void HandleMovement()
    {
        RigidBody.MovePosition(RigidBody.position + (currentMoveDirection * MoveSpeed * Time.fixedDeltaTime));
    }
   
    private void OnEnable()
    {
        // Subscribe to the MoveEvent
        InputActions.MoveEvent += UpdateMoveDirection;
    }

    private void OnDisable()
    {
        // Unsubscribe to MoveEvent
        InputActions.MoveEvent -= UpdateMoveDirection;
    }
}
