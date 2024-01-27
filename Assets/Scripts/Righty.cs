using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Righty : MonoBehaviour
{
    public bool downpressed;
    public bool pressed;
    public Colisao colisao_;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            downpressed = true;
        }
        else { downpressed = false; }
        if (pressed && downpressed)
        {
            colisao_.points++;
            Debug.Log(colisao_.points);
            Destroy(gameObject);
        }
        if (!pressed && downpressed)
        {
            colisao_.points--;
            Debug.Log(colisao_.points);
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