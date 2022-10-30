using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementFish : MonoBehaviour
{
    [SerializeField] float swimmingSpeed = 200f;
    [SerializeField] float turnSpeed = 40f;
    [SerializeField] Vector3 baseRotation = new Vector3(0, 0, 0);

    Transform fishTransform;

    Rigidbody rb;

    Vector3 testturn;

    Quaternion desiredRotation;
    [SerializeField] float speed = 30f; //in degrees


    private void Awake()
    {
        fishTransform = transform;
        desiredRotation = transform.rotation;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Thrust();
        //Turn();
    }

    private void LateUpdate()
    {
        rb.MoveRotation(Quaternion.RotateTowards(rb.rotation, desiredRotation, speed * Time.deltaTime));
        //RotateZAxes();
    }

    void RotateZAxes()
    {
        Vector3 to = new Vector3(fishTransform.eulerAngles.x, fishTransform.eulerAngles.y, baseRotation.z);
        Debug.Log(Vector3.Distance(transform.eulerAngles, to));
        float distance = Vector3.Distance(transform.eulerAngles, to);
        if (distance > 0.01f)
        {
        //fishTransform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, to, Time.deltaTime);
        }
        else if (-distance > -0.01f)
        {
        //fishTransform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, to, Time.deltaTime);
        }
        //else
        //{
        //    fishTransform.eulerAngles = to;
        //}
    }
    void Thrust()
    {
        //fishTransform.position += fishTransform.forward * swimmingSpeed * Time.deltaTime * Input.GetAxis("Vertical");
        //rb.AddTorque(new Vector3(turnSpeed * Time.deltaTime * Input.GetAxis("Vertical"), turnSpeed * Time.deltaTime * Input.GetAxis("Horizontal"), 0));
        rb.AddTorque(transform.right * Time.deltaTime * Input.GetAxis("Vertical") * turnSpeed);
        Debug.Log(Input.GetAxis("Horizontal"));
        rb.AddTorque(transform.up * Time.deltaTime * Input.GetAxis("Horizontal") * turnSpeed);
        if (Input.GetButton("Jump"))
        {
            rb.AddForce(transform.forward * swimmingSpeed * Time.deltaTime);
        }
    }

    void Turn()
    {
        float yaw = turnSpeed * Time.deltaTime * Input.GetAxis("Horizontal");
        float pitch = turnSpeed * Time.deltaTime * Input.GetAxis("Pitch");
        float roll = turnSpeed * Time.deltaTime * Input.GetAxis("Roll");
        fishTransform.Rotate(-pitch, yaw, -roll);
    }
}

