using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundColorChanger : MonoBehaviour{

    private Renderer rend;

    [SerializeField] private float speed = 1.0f;

    void Start() {

        rend = gameObject.GetComponent<Renderer>();

        rend.material.color = Color.HSVToRGB(.34f, .84f, .67f);
    
    }

    void Update() {
    
        float h, s, v;

        Color.RGBToHSV(rend.material.color, out h, out s, out v);

        rend.material.color = Color.HSVToRGB(h + Time.deltaTime * .25f * speed, s, v);
    
    }

}
