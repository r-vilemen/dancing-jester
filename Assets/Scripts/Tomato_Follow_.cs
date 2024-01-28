using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tomato_Follow : MonoBehaviour
{
    public Rigidbody2D rb;
    public Transform Payaso;
    public float forca = 10f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 direcao = (Payaso.position - transform.position).normalized;

        rb.AddForce(direcao * forca);
    }
}
