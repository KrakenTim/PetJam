using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementFish : MonoBehaviour
{
    [SerializeField] float swimmingSpeed = 50f;
    [SerializeField] float turnSpeed = 60f;

    Transform fishTransform;

    Rigidbody rb;

    Vector3 testturn;

    private void Awake()
    {
        fishTransform = transform;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Thrust();
        //Turn();
    }

    void Turn()
    {
        float yaw = turnSpeed * Time.deltaTime * Input.GetAxis("Horizontal");
        float pitch = turnSpeed * Time.deltaTime * Input.GetAxis("Pitch");
        float roll = turnSpeed * Time.deltaTime * Input.GetAxis("Roll");
        fishTransform.Rotate(-pitch, yaw, -roll);
    }

    void Thrust()
    {
        //fishTransform.position += fishTransform.forward * swimmingSpeed * Time.deltaTime * Input.GetAxis("Vertical");
        //rb.AddTorque(new Vector3(turnSpeed * Time.deltaTime * Input.GetAxis("Vertical"), turnSpeed * Time.deltaTime * Input.GetAxis("Horizontal"), 0));
        rb.AddTorque(transform.right * Time.deltaTime * Input.GetAxis("Vertical") * turnSpeed);
        rb.AddTorque(transform.up * Time.deltaTime * Input.GetAxis("Horizontal") * turnSpeed);
        if (Input.GetButton("Jump"))
        {
            rb.AddForce(transform.forward * swimmingSpeed * Time.deltaTime);
        }
 
    }
}

