using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    //Public Variables
    public GameObject propeller;

    //Private Variables
    private float speed = 20;
    private float propellerSpeed = 100;
    private float rotationSpeed = 100;
    private float verticalInput;

    // Start is called before the first frame update
    void Start() {}

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        //rotate propeller
        propeller.transform.Rotate(Vector3.forward * propellerSpeed);

        // move the plane forward at a constant rate
        transform.Translate(speed * Time.deltaTime * Vector3.forward);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(rotationSpeed * Time.deltaTime * verticalInput * Vector3.right);
    }
}
