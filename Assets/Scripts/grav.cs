using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grav : MonoBehaviour
{

    public float arrowSpeed = -5;
    void Start()
    {

    }

    void Update()
    {
        transform.Translate(0, arrowSpeed * Time.deltaTime, 0);
    }
}
