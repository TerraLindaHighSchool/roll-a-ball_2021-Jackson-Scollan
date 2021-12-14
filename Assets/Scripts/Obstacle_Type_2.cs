using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_Type_2 : MonoBehaviour
{

    // Spins obstacle counterclockwise
    void Update()
    {
        transform.Rotate(0, -110 * Time.deltaTime, 0);
    }
}

