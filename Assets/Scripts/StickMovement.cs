using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickMovement : MonoBehaviour{

    [SerializeField] private float movementSpeed;
    [SerializeField] private float rotationSpeed;

    [SerializeField] private float maxHeight;
    [SerializeField] private float minHeight;

    public bool controlsEnabled;

    void Update(){

        if (!controlsEnabled) return;

        // Horizontal movement
        if (Input.GetKey(Keybinds.keybinds["right"])) transform.position += transform.right * Time.deltaTime * movementSpeed; // Move right
        if (Input.GetKey(Keybinds.keybinds["left"])) transform.position -= transform.right * Time.deltaTime * movementSpeed; // Move left
        if (Input.GetKey(Keybinds.keybinds["forward"])) transform.position += transform.forward * Time.deltaTime * movementSpeed; // Move forwards
        if (Input.GetKey(Keybinds.keybinds["back"])) transform.position -= transform.forward * Time.deltaTime * movementSpeed; // Move Backwards

        bool tooHigh = (transform.position.y > maxHeight) ? true : false;
        bool tooLow = (transform.position.y < minHeight) ? true : false;

        // Vertical movement
        if (Input.GetKey(Keybinds.keybinds["up"]) && !tooHigh) transform.position += transform.up * Time.deltaTime * movementSpeed; //Move up
        if (Input.GetKey(Keybinds.keybinds["down"]) && !tooLow) transform.position -= transform.up * Time.deltaTime * movementSpeed; // Move down

        // Rotation
        if (Input.GetKey(Keybinds.keybinds["rotateRight"])) transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f, Space.Self); // Rotate right
        if (Input.GetKey(Keybinds.keybinds["rotateLeft"])) transform.Rotate(0f, -rotationSpeed * Time.deltaTime, 0f, Space.Self); // Rotate left

    }

}
