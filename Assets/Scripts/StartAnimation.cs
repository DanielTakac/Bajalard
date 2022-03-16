using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAnimation : MonoBehaviour{

    [SerializeField] private List<float> xPositions = new List<float>();
    [SerializeField] private List<float> yPositions = new List<float>();
    [SerializeField] private List<float> zPositions = new List<float>();

    private GameObject[] balls = new GameObject[15];

    private int counter = 0;

    [SerializeField] private float animationSpeed;

    void Start(){

        balls = GameObject.FindGameObjectsWithTag("Ball");

        float time = 0f;

        for (int i = 0; i < 15; i++) {

            Invoke("SpawnBall", time);

            time += animationSpeed;

        }
        
    }

    private void SpawnBall() {

        balls[counter].transform.position = new Vector3(xPositions[counter], yPositions[counter] + 1f, zPositions[counter]);

        counter++;

    }

}
