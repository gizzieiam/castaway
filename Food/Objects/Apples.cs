using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Hunger;

public class Apples : MonoBehaviour
{
    float timer;
    bool eat;
    bool pickUp;
    public GameObject Player;
    
    void Update()
    {
        if(eat)
        {
            timer = timer + Time.deltaTime;

            if(Input.GetKey(KeyCode.V))
            {
                Destroy(this.gameObject);
                HungerIncrement("fruit");
            }
        }

        if(pickUp)
        {
            //add to inventory;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == Player)
        {
            eat = true;
            pickUp = true;
        }else
        {
            eat = false;
            pickUp = false;
        }
    }
}
