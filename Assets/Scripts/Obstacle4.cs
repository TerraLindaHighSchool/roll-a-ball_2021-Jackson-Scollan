using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle4 : MonoBehaviour
{
    // Spins fast obstacle 4 counterclockwise
    void Update()
    {
        transform.Rotate(0, -90 * Time.deltaTime, 0);
    }
}
