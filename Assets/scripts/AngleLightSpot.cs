using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AngleLightSpot : MonoBehaviour
{
    // Pulse light's range between original range
    // and half of the original one

    float duration = 3.0f;
    float originalRange;

    Light lt;

    void Start()
    {
        lt = GetComponent<Light>();
        originalRange = lt.range;
    }

    void Update()
    {
        var amplitude = 100;

        if (Input.GetKey(KeyCode.E))
        {
            

            // Transform from 0..duration to 0.5..1 range.
            amplitude = 0;

        }

        // Set light range.
        lt.range = originalRange * amplitude;
    }

}
