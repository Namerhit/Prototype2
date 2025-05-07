using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int _lives = 5;
    private int _score = 0;

    public void AddScore()
    {
        _score++;
        Debug.Log($"Score: {_score}");
    }

    public void LoseLive()
    {
        _lives--;
        Debug.Log($"Lives {_lives}");
        if (_lives <= 0)
        {
            Debug.Log("Game Over!");
            Time.timeScale = 0;
        }
    }
}
