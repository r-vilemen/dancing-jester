using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lefty : MonoBehaviour
{
    public bool leftpressed;
    //public bool downpressed;
    //public bool rightpressed;
    //public bool uppressed;
    public bool pressed;

    //public int keydown;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow)) leftpressed = true;
        if (Input.GetKeyUp(KeyCode.LeftArrow)) leftpressed = false;

        //if (Input.GetKeyDown(KeyCode.DownArrow)) downpressed = true;
        //if (Input.GetKeyUp(KeyCode.DownArrow)) downpressed = false;

        //if (Input.GetKeyDown(KeyCode.RightArrow)) rightpressed = true;
        //if (Input.GetKeyUp(KeyCode.RightArrow)) rightpressed = false;

        //if (Input.GetKeyDown(KeyCode.UpArrow)) uppressed = true;
        //if (Input.GetKeyUp(KeyCode.UpArrow)) uppressed = false;

        if (pressed && leftpressed)
        {
            Pontos.pontuacao++;
            Destroy(gameObject);
        }
        //if (pressed && rightpressed)
        //{
        //    Pontos.pontuacao++;
        //    Destroy(gameObject);
        //}
        //if (pressed && downpressed)
        //{
        //    Pontos.pontuacao++;
        //    Destroy(gameObject);
        //}
        //if (pressed && uppressed)
        //{
        //    Pontos.pontuacao++;
        //    Destroy(gameObject);
        //}

        
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