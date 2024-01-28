using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lefty : MonoBehaviour
{
    public bool leftpressed;
    public bool downpressed;
    public bool rightpressed;
    public bool uppressed;
    public bool pressed;

    public int keydown;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            leftpressed = true;
            keydown = 1;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            downpressed = true;
            keydown = 1;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rightpressed = true;
            keydown = 1;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            uppressed = true;
            keydown = 1;

        }
        if (pressed && leftpressed)
        {
            Pontos.pontuacao++;
            Destroy(gameObject);
            keydown = 0;
        }
        /*else if (!pressed && keydown == 1)
        {
            Pontos.pontuacao--;
            keydown = 0;
        }*/

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Alvo")) { pressed = true; }
        if (col.gameObject.CompareTag("Deadline")){
            Pontos.pontuacao--;
            Destroy(gameObject);
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Alvo")) { pressed = false; }
    }
}