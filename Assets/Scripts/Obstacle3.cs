using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle3 : MonoBehaviour
{
    // Spins fast obstacle 3 clockwise
    void Update()
    {
        transform.Rotate(0, 90 * Time.deltaTime, 0);
    }
}
