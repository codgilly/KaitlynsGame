using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlayer3D : MonoBehaviour
{
    public float speed;
    public float jumpForce;

    [Space(15)]
    public float CheckDistance;
    public Transform GroundCheck;
    public LayerMask GroundMask;

    [Space(15)]
    public Transform PlayerMesh;

    [Space(15)]
    public bool canJump;
    public bool canMove;

    void FixedUpdate()
    {
        Cursor.lockState = CursorLockMode.Locked;

        Rigidbody rb = GetComponent<Rigidbody>();

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 forward = Camera.main.transform.forward;
        Vector3 right = Camera.main.transform.right;

        forward.y = 0;
        right.y = 0;

        forward.Normalize();
        right.Normalize();

        Vector3 MoveDirection = forward * verticalInput + right * horizontalInput;

        rb.velocity = new Vector3(MoveDirection.x * speed, rb.velocity.y, MoveDirection.z * speed);

        if (MoveDirection != new Vector3(0, 0, 0))
        {
            PlayerMesh.rotation = Quaternion.LookRotation(MoveDirection);

        }
    }
}

