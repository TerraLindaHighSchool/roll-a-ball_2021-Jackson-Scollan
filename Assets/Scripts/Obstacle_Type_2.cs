using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_Type_2 : MonoBehaviour
{
  
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0 * Time.deltaTime, -110 * Time.deltaTime, 0 * Time.deltaTime);
    }
}
