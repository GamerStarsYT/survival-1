using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Movement Settings")]
    public float walkSpeed = 4f;
    public float runSpeed = 8f;   
    public float jumpForce = 2f;   
    public float gravity = 15f;    

    [Header("Camera Settings")]
    public Transform playerCamera;
    public float mouseSensitivity = 2f;
    public float xRotation;

    [Header("Ground Check Settings")]
    public float groundCheckDistance = 1.3f;
    public LayerMask groundLayer;
    public float groundCheckOffset = 0.1f;

    [Header("Crouch Settings")]
    public float crouchHeight = 1f;
    public float standHeight = 2f;
    public bool isCrouching = false;


    [Header("Crouch Settings")]
    public float maxSlopeAngle = 45f;

    [Header("Other Settings")]
    private Vector3 velocity;
    public bool isGrounded;
    public bool isRunning = false;
    private Transform cameraHolder;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        ReallyIsGrounded();
    }


    private void HandleMovement()
    {

    }

    private void HandleJumping()
    {

    }

    private void HandleCrouch()
    {

    }

    private void HandleCameraRotation()
    {

    }

    private void ReallyIsGrounded()
    {
        Vector3 rayOrigin = transform.position + (Vector3.up * groundCheckOffset);
        isGrounded = Physics.Raycast(rayOrigin, Vector3.down, groundCheckDistance, groundLayer);
        Debug.DrawRay(rayOrigin, Vector3.down * groundCheckDistance, isGrounded ? Color.green : Color.red);
    }
}