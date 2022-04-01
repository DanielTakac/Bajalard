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

    }

}
