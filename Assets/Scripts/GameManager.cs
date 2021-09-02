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
    public Image[] imageHolders;
    public Sprite[] images;

    void TickTimer()
    {
        if(timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
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
