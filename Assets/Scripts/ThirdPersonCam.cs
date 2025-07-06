using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ThirdPersonCam : MonoBehaviour
{
    //public Transform playerObj;
    public Transform player;
    public Rigidbody rb;
    public InputAction playerControls;
    public float moveSpeed;

    private void OnEnable(){
        playerControls.Enable();
    }

    private void OnDisable(){
        playerControls.Disable();
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = false;
    }

    private void FixedUpdate(){
        Vector2 moveDirection = playerControls.ReadValue<Vector2>();
        rb.linearVelocity = new Vector3(moveDirection.x * moveSpeed, rb.linearVelocity.y , moveDirection.y * moveSpeed);
    }
}
