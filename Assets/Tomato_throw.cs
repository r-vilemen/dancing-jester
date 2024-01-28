using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tomato_throw : MonoBehaviour
{
    public Transform TomatoPlace1;
    public Transform TomatoPlace2;
    public bool TomatoSide;
    public GameObject Tomato__;
    void Start()
    {

    }

    void Update()
    {
        if (TomatoSide == true)
        {
            Instantiate(Tomato__, TomatoPlace1.position, Quaternion.identity);
            TomatoPlace1.transform.position = Vector2.MoveTowards(transform.position, TomatoPlace1.transform.position, 5 * Time.deltaTime);
            TomatoSide = false;
        }
        if (TomatoSide == false)
        {
            Instantiate(Tomato__, TomatoPlace1.position, Quaternion.identity);
            TomatoPlace1.transform.position = Vector2.MoveTowards(transform.position, TomatoPlace1.transform.position, 5 * Time.deltaTime);
            TomatoSide = true;
        }

    }
}
