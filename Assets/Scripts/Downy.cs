using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Downy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Alvo") && Input.GetKey(KeyCode.DownArrow))
        {
            Destroy(gameObject);
        }
    }
}
