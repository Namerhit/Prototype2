using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DetectCollisions : MonoBehaviour
{
    public Slider hpSlider;
    private int _hp = 3;
    private GameManager _gameManager;
    void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
        
        hpSlider.value = 3;
        hpSlider.minValue = 0;
        hpSlider.maxValue = 3;
    }

    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _gameManager.LoseLive();
        }
        
        _hp--;
        hpSlider.value = _hp;
        if (_hp<=0)
        {
            _gameManager.AddScore();
            Destroy(gameObject); 
        }
        Destroy(other.gameObject);
    }
}
