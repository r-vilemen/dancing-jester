using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tomato_spawner : MonoBehaviour
{
    public GameObject Tomato__;
    public Transform TomatoPlace1;
    public Transform TomatoPlace2;
    public bool TomatoSide;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (TomatoSide)
            {
                Instantiate(Tomato__, TomatoPlace1.position, Quaternion.identity);
                TomatoSide = false;
            }
            else
            {
                Instantiate(Tomato__, TomatoPlace2.position, Quaternion.identity);
                TomatoSide = true;
            }
        }
    }
}
//
