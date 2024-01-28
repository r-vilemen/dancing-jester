using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrongRight : MonoBehaviour
{

    public bool downpressed;
    public bool pressed;
    public Colisao colisao_;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            downpressed = true;
        }
        else { downpressed = false; }
        if (pressed && downpressed)
        {
            Pontos.pontuacao--;
            Destroy(gameObject);
        }

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Alvo")) { pressed = true; }
        if (col.gameObject.CompareTag("Deadline"))
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Alvo")) { pressed = false; }
    }
}
