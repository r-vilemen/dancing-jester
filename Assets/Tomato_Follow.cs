using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tomato_Follow_ : MonoBehaviour
{
    public Transform Payaso;
    void Start()
    {

    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Payaso.transform.position, 12 * Time.deltaTime);
    }
}
