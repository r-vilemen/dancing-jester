using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrongDown : MonoBehaviour
{

    public bool downpressed;
    public bool pressed;
    public Colisao colisao_;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            downpressed = true;
        }
        else { downpressed = false; }
        if (pressed && downpressed)
        {
            colisao_.points--;
            Debug.Log(colisao_.points);
            Destroy(gameObject);
        }
        if (!pressed && downpressed)
        {
            colisao_.points--;
            Debug.Log(colisao_.points);
            Destroy(gameObject);
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
