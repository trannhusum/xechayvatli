using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveForce = 10f; // Lực di chuyển
    public float rotationForce = 100f; // Lực quay

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Lấy giá trị đầu vào từ Input Manager
        float moveInput = Input.GetAxis("Vertical");
        float rotateInput = Input.GetAxis("Horizontal");

        // Áp dụng lực di chuyển
        Vector3 moveDirection = transform.forward * moveInput * moveForce;
        rb.AddForce(moveDirection);

        // Áp dụng lực quay
        Vector3 rotationTorque = Vector3.up * rotateInput * rotationForce;
        rb.AddTorque(rotationTorque);
    }
}

