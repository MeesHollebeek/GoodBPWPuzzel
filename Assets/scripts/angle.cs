using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class angle : MonoBehaviour
{
    // Change spot angle randomly between 'minAngle' and 'maxAngle'
    // each 'interval' seconds.


    Light lt;


    void Start()
    {
        lt = GetComponent<Light>();
        lt.type = LightType.Spot;

    }

    void Update()
    {
        lt.spotAngle = 0;

        if (Input.GetKey(KeyCode.Q))
        {
            lt.spotAngle = 50;
        }

        if (Input.GetKey(KeyCode.F))
        {
            lt.spotAngle = 0;
        }


    }
}
