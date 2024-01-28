using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upy : MonoBehaviour
{
    //public bool leftpressed;
    //public bool downpressed;
    //public bool rightpressed;
    public bool uppressed;
    public bool pressed;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.LeftArrow))
        //{
        //    leftpressed = true;
        //}
        //if (Input.GetKeyDown(KeyCode.DownArrow))
        //{
        //    downpressed = true;
        //}
        if (Input.GetKeyDown(KeyCode.UpArrow)) uppressed = true;
        if (Input.GetKeyUp(KeyCode.UpArrow)) uppressed = false;

        //if (Input.GetKeyDown(KeyCode.UpArrow))
        //{
        //    uppressed = true;

        //}
        if (pressed && uppressed)
        {
            Pontos.pontuacao++;
            Destroy(gameObject);
        }
        //else if (!pressed && keydown == 1)
        //{
        //    Pontos.pontuacao--;
        //}

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Alvo")) { pressed = true; }
        if (col.gameObject.CompareTag("Deadline"))
        {
            Pontos.pontuacao--;
            Destroy(gameObject);
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Alvo")) { pressed = false; }
    }
}