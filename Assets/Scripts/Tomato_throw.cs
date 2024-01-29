using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tomato_spawner : MonoBehaviour
{
    public GameObject Tomato__;
    public GameObject TomatoSauce;
    public Transform TomatoPlace1;
    public Transform TomatoPlace2;
    public bool TomatoSide;
    public bool Tom;


    void Update()
    {
        if (Tom == true)
        {
            if (TomatoSide)
            {
                Instantiate(TomatoSauce, TomatoPlace1.position, Quaternion.identity);
                Instantiate(Tomato__, TomatoPlace1.position, Quaternion.identity);
                TomatoSide = false;
            }
            else
            {
                Instantiate(TomatoSauce, TomatoPlace1.position, Quaternion.identity);
                Instantiate(Tomato__, TomatoPlace2.position, Quaternion.identity);
                TomatoSide = true;
            }
        }
    }
}
//
