using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour{

    [SerializeField] private Transform stick;

    [SerializeField] private Vector3 defaultPosition;
    [SerializeField] private Quaternion defaultRotation;

    [SerializeField] private Vector3 followOffset;

    private bool followStick = false;

    void Update(){

        if (followStick) {

            // Sets the position & rotation of this object to look at the stick
            transform.position = stick.position + followOffset;
            //transform.rotation = new Quaternion(-stick.rotation.x, -stick.rotation.y, -stick.rotation.z, -stick.rotation.w);
            //transform.rotation = stick.rotation;
            transform.forward = -stick.forward;

        } else {

            // Sets the position & rotation of this object to default
            transform.position = defaultPosition;
            transform.rotation = defaultRotation;

        }

        // Switch between following and default by pressing space
        if (Input.GetKeyDown("space")) followStick = !followStick;

    }

}
