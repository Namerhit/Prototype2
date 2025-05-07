using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = 30;
    private float rightLimit = -35;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > leftLimit)
        {
            Destroy(gameObject);
        } 
        else if (transform.position.x < rightLimit)
        {
            Destroy(gameObject);
        }

    }
}
