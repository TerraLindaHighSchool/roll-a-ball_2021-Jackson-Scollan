using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speedy_Obstacle : MonoBehaviour
{
    // Spins fast obstacle clockwise
    void Update()
    {
        transform.Rotate(0, 245 * Time.deltaTime, 0);
    }
}
