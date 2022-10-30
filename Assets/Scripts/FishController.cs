using UnityEngine;

public class FishController : MonoBehaviour
{
    [SerializeField] float swimmingSpeed = 50f;
    [SerializeField] float turnSpeed = 60f; 

    Transform fishTransform;

    private void Awake()
    {
        fishTransform = transform;
    }

    void Update()
    {
        Thrust();
        Turn();
    }

    void Turn()
    {
        float yaw = turnSpeed * Time.deltaTime * Input.GetAxis("Horizontal");
        float pitch = turnSpeed * Time.deltaTime * Input.GetAxis("Pitch");
        float roll = turnSpeed * Time.deltaTime * Input.GetAxis("Roll");
        fishTransform.Rotate(-pitch,yaw,-roll);
    }

    void Thrust()
    {
        if (Input.GetAxis("Vertical") > 0)
        {
            fishTransform.position += fishTransform.forward * swimmingSpeed * Time.deltaTime * Input.GetAxis("Vertical");
        }
    }
}
