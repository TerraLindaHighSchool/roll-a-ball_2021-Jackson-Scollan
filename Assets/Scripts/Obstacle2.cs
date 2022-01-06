using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle2 : MonoBehaviour
{

    // Spins obstacle 2 counterclockwise
    void Update()
    {
        transform.Rotate(0, -145 * Time.deltaTime, 0);
    }
}

