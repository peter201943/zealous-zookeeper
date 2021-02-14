using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodRes : MonoBehaviour
{
    public GameObject FoodImage;
    public float SpawnTime;
    public float timer;
    public bool taken, StartTimer;


    void Update()
    {
       
        if(taken == true)
        {
            timer = timer + Time.deltaTime;
        }
        if(timer >= SpawnTime)
        {
            for (int a = 0; a < transform.childCount; a++)
            {
                transform.GetChild(a).gameObject.SetActive(true);
            }
            taken = false;
            timer = 0;
        }
    }

    public void setfood()
    {
        for (int a = 0; a < transform.childCount; a++)
        {
            transform.GetChild(a).gameObject.SetActive(false);
        }
        taken = true;
    }

}
