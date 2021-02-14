using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static PlayerMovement;


public class Hygiene : MonoBehaviour
{
    int maxHygiene = 10;
    int hygieneStat;
    // float timer;
    bool isStinky;
    void Start()
    {
        hygieneStat = 5;

    }

    void Update()
    {
        if(isActive)
        {
            hygieneStat --;
            isActive = false;
        }
        
        if(hygieneStat > maxHygiene)
        {
            hygieneStat = maxHygiene;
        }

        if(hygieneStat == 0)
        {
            isStinky = true;
            // if player is stinky increase the random chance of animal attack
        }
        GameObject.Find("HygieneUI").GetComponent<Text>().text = "Hygiene: " + hygieneStat.ToString();
    }
}
