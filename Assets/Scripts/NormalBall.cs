 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalBall : MonoBehaviour{

    void FixedUpdate() {

        if (transform.position.y < 0.2f) {

            GameManager.score++;

            Destroy(gameObject);

        }

    }

}
