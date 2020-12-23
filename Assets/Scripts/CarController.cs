using UnityEngine;

public class CarController : MonoBehaviour
{
    public Rigidbody controllerRB;
    
    public float forwardAccel = 8f;
    public float reverseAccel = 4f;
    public float maxSpeed = 50f;
    public float turnStrength = 180f;
    public float gravityForce = 10f;
    public float dragOnGround = 3f;

    private float currentSpeed = 0f;
    public static float speedInput;
    private float turnInput;
    private bool isGrounded;

    public LayerMask whatIsGround;
    public float groundRayLength = 0.5f;
    public Transform rayPoint;

    public Transform leftFrontWheel, rightFrontWheel;
    public float maxWheelTurn;

    void Start()
    {
        controllerRB.transform.parent = null;
    }

    void Update()
    {
        speedInput = 0;
        if (Input.GetAxis("Vertical") > 0)
        {
            speedInput = Input.GetAxis("Vertical") * forwardAccel * 1000f;  
        } 
        else if (Input.GetAxis("Vertical") < 0)
        {
            speedInput = Input.GetAxis("Vertical") * reverseAccel * 1000f;
        }

        turnInput = Input.GetAxis("Horizontal");

        if (isGrounded)
        {
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, turnInput * turnStrength * Time.deltaTime * Input.GetAxis("Vertical"), 0f));
        }
        leftFrontWheel.localRotation = Quaternion.Euler(leftFrontWheel.localRotation.eulerAngles.x, (turnInput * maxWheelTurn) - 180, leftFrontWheel.localRotation.eulerAngles.z);
        rightFrontWheel.localRotation = Quaternion.Euler(rightFrontWheel.localRotation.eulerAngles.x, (turnInput * maxWheelTurn), rightFrontWheel.localRotation.eulerAngles.z);

        transform.position = controllerRB.transform.position;
    }

    void FixedUpdate()
    {
        isGrounded = false;
        RaycastHit hit;

        if (Physics.Raycast(rayPoint.position, -transform.up, out hit, groundRayLength, whatIsGround))
        {
            isGrounded = true;

            transform.rotation = Quaternion.FromToRotation(transform.up, hit.normal) * transform.rotation;
        }

        if (isGrounded)
        {
            controllerRB.drag = dragOnGround;
            if (Mathf.Abs(speedInput) > 0)
            {
                controllerRB.AddForce(transform.forward * speedInput);
            }
        }
        else
        {
            controllerRB.drag = 0.1f;
            controllerRB.AddForce(Vector3.up * -gravityForce * 100);
        }
            
    }
}
