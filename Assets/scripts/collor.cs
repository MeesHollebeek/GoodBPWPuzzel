using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collor : MonoBehaviour
{
    // Interpolate light color between two colors back and forth
    float duration = 1.0f;
    Color color0 = Color.red;
    Color color1 = Color.blue;

    Color lerpedColor = Color.white;


    Light lt;

    void Start()
    {
        lt = GetComponent<Light>();
    }

    void Update()
    {
        lerpedColor = Color.white;
        lt.color = lerpedColor;

        if (Input.GetKey(KeyCode.Q))
        {
            
            lt.color = Color.Lerp(color0, color1, 0.8f);
        }
    }
}
