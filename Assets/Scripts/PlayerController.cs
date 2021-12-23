using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   // Private variables

    private float speed = 10.0f;
    private float turnSpeed = 50.0f;
    private float horizontalInput;
    private float verticalInput;
    public Camera mainCamera;
    public Camera FrontViewCamera;
    public KeyCode switchKey;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // This is where we get player input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // We move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        // We turn the vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            FrontViewCamera.enabled = !FrontViewCamera.enabled;
        }

    }
}
