using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteBall : MonoBehaviour{

    private Vector3 startPosition;
    private bool reset;
    
    void Start(){

        startPosition = transform.position;
        
    }

    void Update(){

        if (transform.position.y < 0.2f) Invoke("ResetBall", 0.5f);

        if (reset) {

            reset = false;
            transform.position = startPosition;
            GetComponent<Rigidbody>().velocity = Vector3.zero;
        
        }

    }

    public void ResetBall() {

        reset = true;

    }

}
