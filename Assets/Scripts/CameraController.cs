using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour{

    [SerializeField] private Vector3 primaryPosition;
    [SerializeField] private Quaternion primaryRotation;

    [SerializeField] private Vector3 secondaryPosition;
    [SerializeField] private Quaternion secondaryRotation;

    private bool cameraMode = true;

    void Update(){

        if (cameraMode) {

            // Primary camera
            transform.position = primaryPosition;
            transform.rotation = primaryRotation;

        } else {

            // Secondary camera
            transform.position = secondaryPosition;
            transform.rotation = secondaryRotation;

        }

        // Switch between primary and secondary camera by pressing a button
        if (Input.GetKeyDown(Keybinds.keybinds["toggleCamera"])) cameraMode = !cameraMode;

        /*if (followStick) {

            // Sets the position & rotation of this object to look at the stick
            transform.position = stick.position + followOffset;
            transform.forward = -stick.forward;

        } else {

            // Sets the position & rotation of this object to default
            transform.position = defaultPosition;
            transform.rotation = defaultRotation;

        }

        // Switch between following and default by pressing x
        if (Input.GetKeyDown("x")) followStick = !followStick;*/

    }

}
