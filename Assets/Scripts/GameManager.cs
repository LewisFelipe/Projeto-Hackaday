using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    float timer;
    int count = 0;

    void TickTimer()
    {
        count += (int)Time.deltaTime;
        timer = count;
        //if ()
    }

    void Update()
    {
        TickTimer();
    }
}
