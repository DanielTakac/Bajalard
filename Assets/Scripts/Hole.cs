using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour{

    [SerializeField] private float destroyDelay = 2f;

    private void OnCollisionEnter(Collision collision) {

        if (collision.gameObject.tag != "Ball") return;

        Destroy(collision.gameObject, destroyDelay);

        GameManager.score++;

    }

}
