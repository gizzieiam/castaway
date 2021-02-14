using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Hunger : MonoBehaviour
{
    int maxHunger = 10;
    int hungerStat;
    float timer;
    bool isStarving;
    // bool isDead;

    void Start()
    {
        hungerStat = 5;
        timer = 0.0f;
    }

    void Update()
    {

        if(hungerStat == 0)
        {
            isStarving = true;
        }else
        {
            isStarving = false;
        }

        if(hungerStat > maxHunger)
        {
            hungerStat = maxHunger;
        }

        if(isStarving)
        {
            timer = timer + Time.deltaTime;
            int seconds = (int) (timer%60);
            int minutes = (int) (timer/60);
            
            if (minutes == 2)
            {
                // died of hunger
            }
        }

        HungerDecrement();
        GameObject.Find("HungerUI").GetComponent<Text>().text = "Hunger: " + hungerStat.ToString();
    }

    void HungerDecrement()
    {
        timer = timer + Time.deltaTime;
        int seconds = (int) (timer%60);
        int minutes = (int) (timer/60);

        if(minutes == 1)
        {
            hungerStat --;
            timer = 0.0f;
        }
    }

    void HungerIncrement(string food)
    {
        if(food == "fruit")
        {
            hungerStat += 1;
        }else if(food == "meat")
        {
            hungerStat += 2;
        }else if(food == "cooked")
        {
            hungerStat += 5;
        }else if (food == "poison")
        {
            int ranIncrease = Random.Range(1, 6);
            hungerStat += ranIncrease;
            if(ranIncrease%2==1)
            {
                // player is poisoned
            }

        }
    }
}
