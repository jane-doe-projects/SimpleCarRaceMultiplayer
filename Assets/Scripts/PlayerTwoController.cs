using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwoController : MonoBehaviour
{
    // Movement and turn speeds
    public float speed = 10.0f;
    private float turnSpeed = 50.0f;
    // Player input
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Move the vehicle forward
        horizontalInput = Input.GetAxis("Horizontal Player2");
        forwardInput = Input.GetAxis("Vertical Player2");
        // Moves the car forward based on the vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Rotates the car based on the horizontal input
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
