using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private bool _canSpawn = true;

    void Start()
    {
        InvokeRepeating("CanSpawn", 0, 1);    
    }

    void CanSpawn()
    {
        _canSpawn = true;
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _canSpawn)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            _canSpawn = false;
        }
    }
}
