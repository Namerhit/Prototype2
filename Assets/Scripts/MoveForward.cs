using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] private float speed = 40.0f;
    private float _topBound = 30.0f;
    private float _lowerBound = -10.0f;
    void Start()
    {
        
    }

    void Update()
    {
        if (transform.position.z > _topBound)
        {
            Destroy(gameObject);
        } else if (transform.position.z < _lowerBound)
        {
            Destroy(gameObject);
        }
        
        transform.Translate(Vector3.forward * (speed * Time.deltaTime));
    }
}
