using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour{

    private Light hue;

    [SerializeField] private float speed = 1.0f;

    [SerializeField] private float minBrightness = 0.5f;
    [SerializeField] private float maxBrightness = 1.0f;

    void Start() {

        hue = gameObject.GetComponent<Light>(); // Gets the light component of this object

        var rgb = new List<float>(); // Declares a new list of type float

        for (int i = 0; i <= 3; i++) rgb.Add(GenerateRGB()); // Generates random rgb values

        hue.color = Color.HSVToRGB(rgb[0], rgb[1], rgb[2]); // Assigns the colors to this object
    
    }

    void Update() {
    
        float h, s, v;

        Color.RGBToHSV(hue.color, out h, out s, out v);

        hue.color = Color.HSVToRGB(h + Time.deltaTime * .25f * speed, s, v);
    
    }

    private float GenerateRGB() {

        var rd = new System.Random(Guid.NewGuid().GetHashCode()); // Generates a new random seed

        float value = (float)rd.NextDouble(); // Generates a random value between 0 and 1

        // Generates new values until it's between min and max brightness
        while (value <= minBrightness && value >= maxBrightness) value = (float)rd.NextDouble();

        return value;

    }

}
