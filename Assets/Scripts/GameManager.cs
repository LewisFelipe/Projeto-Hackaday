using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int maxTime;
    int timerInteger = 0;
    float timer;
    public Text lblTimer;

    void TickTimer()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Debug.Log("Game Over");
        }
    }
    
    void Start()
    {
        timer = maxTime;
    }

    void Update()
    {
        timerInteger = (int)timer;
        lblTimer.text = timerInteger.ToString();
        TickTimer();
    }
}
