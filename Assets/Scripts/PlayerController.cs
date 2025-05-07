using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float _horizontalInput;
    private float _verticalInput;
    
    [SerializeField] private float speed = 10f;
    [SerializeField] private GameObject projectile;
    
    private float _xRange = 20f;
    private float _topBound = 16f;
    private float _lowerBound = -1.5f;

    void Start()
    {
        
    }
    
    void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");
        
        transform.Translate(Vector3.right * (_horizontalInput * speed * Time.deltaTime));
        transform.Translate(Vector3.forward * (_verticalInput * speed * Time.deltaTime));

        float currentX = (transform.position.x < -_xRange) ? -_xRange :
            (transform.position.x > _xRange) ? _xRange : transform.position.x;

        float currentZ = (transform.position.z < _lowerBound) ? _lowerBound :
            (transform.position.z > _topBound) ? _topBound : transform.position.z;

        transform.position = new Vector3(currentX, transform.position.y, currentZ);
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectile, transform.position, projectile.transform.rotation);
        }
    }
}
