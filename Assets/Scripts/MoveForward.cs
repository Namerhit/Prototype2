using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    private GameManager _gameManager;
    
    [SerializeField] private float speed;
    private float _topBound = 30f;
    private float _lowerBound = -10f;
    private float _xBound = 30f;
    
    
    void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
    }

    void Update()
    {
        if (transform.position.z > _topBound || transform.position.z < _lowerBound 
                                             || transform.position.x > _xBound || transform.position.x < -_xBound)
        {
            _gameManager.LoseLive();
            Destroy(gameObject);
        } 
        
        transform.Translate(Vector3.forward * (speed * Time.deltaTime));
    }
}
