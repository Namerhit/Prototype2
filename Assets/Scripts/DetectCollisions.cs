using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DetectCollisions : MonoBehaviour
{
    public Slider hpSlider;
    private int _hp = 3;
    
    void Start()
    {
        hpSlider.value = 3;
        hpSlider.minValue = 0;
        hpSlider.maxValue = 3;
    }

    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        _hp--;
        hpSlider.value = _hp;
        if (_hp<=0)
        {
            Destroy(gameObject);    
        }
        Destroy(other.gameObject);
    }
}
