using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle5 : MonoBehaviour
{
    // Spins Obstacle 5 clockwise
    void Update()
    {
        transform.Rotate(130 * Time.deltaTime, 0, 0);
    }
}
