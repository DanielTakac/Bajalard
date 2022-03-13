using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickMovement : MonoBehaviour{

    [SerializeField] private float movementSpeed;
    [SerializeField] private float rotationSpeed;

    [SerializeField] private float maxHeight;
    [SerializeField] private float minHeight;

    void Update(){

        // Horizontal movement
        if (Input.GetKey("d")) transform.position += transform.right * Time.deltaTime * movementSpeed; // Move right
        if (Input.GetKey("a")) transform.position -= transform.right * Time.deltaTime * movementSpeed; // Move left
        if (Input.GetKey("w")) transform.position += transform.forward * Time.deltaTime * movementSpeed; // Move forwards
        if (Input.GetKey("s")) transform.position -= transform.forward * Time.deltaTime * movementSpeed; // Move Backwards

        bool tooHigh = (transform.position.y > maxHeight) ? true : false;
        bool tooLow = (transform.position.y < minHeight) ? true : false;

        // Vertical movement
        if (Input.GetKey("space") && !tooHigh) transform.position += transform.up * Time.deltaTime * movementSpeed; //Move up
        if (Input.GetKey("c") && !tooLow) transform.position -= transform.up * Time.deltaTime * movementSpeed; // Move down

        // Rotation
        if (Input.GetKey("e")) transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f, Space.Self); // Rotate right
        if (Input.GetKey("q")) transform.Rotate(0f, -rotationSpeed * Time.deltaTime, 0f, Space.Self); // Rotate left

    }

}
