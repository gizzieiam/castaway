using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static PlayerMovement;

public class Energy : MonoBehaviour
{
    int maxEnergy = 10;
    int energyStat;
    bool isTired;
    float timer;
    void Start()
    {
        energyStat = 5;
        timer = 0.0f;
    }

    void Update()
    {
        if(energyStat == 0)
        {
            isTired = true;
        }else
        {
            isTired = false;
        }

        if(energyStat > maxEnergy)
        {
            energyStat = maxEnergy;
        }

        if (isTired)
        {
            int count = 0;
            // speed = 1f;
            timer = timer + Time.deltaTime;
            int seconds = (int) (timer%60);
            int minutes = (int) (timer/60);

            if(minutes == 2)
            {
                // player faints 
                timer = 0.0f;
                count ++;

                if(count == 3)
                {
                    // player dies from ...
                    count = 0;
                }
            }


        }
        GameObject.Find("EnergyUI").GetComponent<Text>().text = "Energy: " + energyStat.ToString();
    }
}
