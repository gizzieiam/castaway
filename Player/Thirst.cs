using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Thirst : MonoBehaviour
{
    int maxThirst = 10;
    int thirstStat;
    float timer;
    bool dehydrated;
    void Start()
    {
        thirstStat = 5;
        timer = 0.0f;
    }

    void Update()
    {
        if(thirstStat == 0)
        {
            dehydrated = true;
        }else
        {
            dehydrated = false;
        }

        if (thirstStat > maxThirst)
        {
            thirstStat = maxThirst;
        }

        if(dehydrated)
        {
            timer = timer + Time.deltaTime;
            int seconds = (int) (timer%60);
            int minutes = (int) (timer/60);
            
            if (minutes == 2)
            {
                // died of dehydration
            }

        }
        thirstDecrement();
        GameObject.Find("ThirstUI").GetComponent<Text>().text = "Thirst: " + thirstStat.ToString(); 
    }

    void thirstDecrement()
    {
        timer = timer + Time.deltaTime;
        int seconds = (int) (timer%60);
        int minutes = (int) (timer/60);

        if(minutes == 1)
        {
            thirstStat --;
            timer = 0.0f;
        }
    }
}
