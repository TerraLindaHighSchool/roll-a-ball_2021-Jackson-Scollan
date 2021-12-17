using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speedy_Obstacle_2 : MonoBehaviour
{
    // Spins fast obstacle counterclockwise
    void Update()
    {
        transform.Rotate(0, -190 * Time.deltaTime, 0);
    }
}
