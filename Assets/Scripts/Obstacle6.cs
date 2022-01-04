using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle6 : MonoBehaviour
{
    // Spins Obstacle 6 counterclockwise
    void Update()
    {
        transform.Rotate(-130 * Time.deltaTime, 0, 0);
    }
}
