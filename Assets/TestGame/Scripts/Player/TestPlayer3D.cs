using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlayer3D : MonoBehaviour
{
    public float speed;
    public float maxSpeed;

    private Rigidbody rb;

    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

    }
    void FixedUpdate()
    {
        Cursor.lockState = CursorLockMode.Locked;

        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        if (Input.GetKey("w"))
        {
            var move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            transform.position += move * speed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            var move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            transform.position += move * speed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            transform.Translate(Vector3.right * Time.deltaTime * 1.6f, Camera.main.transform);
        }
        if (Input.GetKey("a"))
        {
            transform.Translate(Vector3.left * Time.deltaTime * 1.6f, Camera.main.transform);
        }
    }
}

