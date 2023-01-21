using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Movement and turn speeds
    public float horsePower = 100.0f;
    [SerializeField] float turnSpeed = 50.0f;

    public GameObject centerOfMass;
    // Player input
    private float horizontalInput;
    private float forwardInput;

    private Rigidbody playerRb;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerRb.centerOfMass = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Move the vehicle forward
        horizontalInput = Input.GetAxis("Horizontal Player1");
        forwardInput = Input.GetAxis("Vertical Player1");
        // Moves the car forward based on the vertical input
        //transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        playerRb.AddRelativeForce(Vector3.forward * horsePower * forwardInput);
        // Rotates the car based on the horizontal input
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
