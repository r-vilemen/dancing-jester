using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Downy : MonoBehaviour
{
    public bool downpressed;
    public bool pressed;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(downpressed);
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            downpressed = true;
        }
        else { downpressed = false; }

        if (pressed && downpressed)
        {
            Debug.Log("Acertou");
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Alvo")) { pressed = true; }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Alvo")) { pressed = false; }
    }
}
