using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsY : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if (transform.position.y <= 0)
        {
            Destroy(gameObject);
            Debug.Log("Game Over!");
        }
    }
}
