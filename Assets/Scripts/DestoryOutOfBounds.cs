using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryOutOfBounds : MonoBehaviour
{
    private float _topBound = 30.0f;
    void Start()
    {
        
    }

    void Update()
    {
        if (transform.position.z > _topBound)
        {
            Destroy(gameObject);
        }
    }
}
