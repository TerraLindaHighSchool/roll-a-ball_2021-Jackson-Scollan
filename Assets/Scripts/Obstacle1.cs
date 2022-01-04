using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle1 : MonoBehaviour
{

    // Spins obstacle 1 clockwise
    void Update()
    {
        transform.Rotate(0 * Time.deltaTime, 110 * Time.deltaTime, 0 * Time.deltaTime);
    }
}
