using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Colision : MonoBehaviour
{
    public bool leftpressed;
    public bool downpressed;
    public bool rightpressed;
    public bool uppressed;

    private GameObject reference;

    public bool isDentro;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            leftpressed = true;
            if (!isDentro) Pontos.pontuacao--;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow)) leftpressed = false;

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            downpressed = true;
            if (!isDentro) Pontos.pontuacao--;

        }
        if (Input.GetKeyUp(KeyCode.DownArrow)) downpressed = false;

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rightpressed = true;
            if (!isDentro) Pontos.pontuacao--;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow)) rightpressed = false;

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            uppressed = true;
            if (!isDentro) Pontos.pontuacao--;
        }
        if (Input.GetKeyUp(KeyCode.UpArrow)) uppressed = false;

        if (isDentro && leftpressed)
        {
            Pontos.pontuacao++;
            Destroy(reference.gameObject);
            isDentro = false;
        }
        if (isDentro && downpressed)
        {
            Pontos.pontuacao++;
            Destroy(reference.gameObject);
            isDentro = false;
        }
        if (isDentro && uppressed)
        {
            Pontos.pontuacao++;
            Destroy(reference.gameObject);
            isDentro = false;
        }
        if (isDentro && downpressed)
        {
            Pontos.pontuacao++;
            Destroy(reference.gameObject);
            isDentro = false;
        }

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("SetaEsq"))
        {
            isDentro = true;
            reference = col.gameObject;
        }
        else if (col.gameObject.CompareTag("SetaUp") && uppressed)
        {
            isDentro = true;
            reference = col.gameObject;
        }
        else if (col.gameObject.CompareTag("SetaDown") && downpressed)
        {
            isDentro = true;
            reference = col.gameObject;
        }
        else if (col.gameObject.CompareTag("SetaDir") && rightpressed)
        {
            isDentro = true;
            reference = col.gameObject;
        }


    }
    void OnTriggerExit2D(Collider2D col)
    {
        Destroy(col.gameObject, .5f);
        isDentro = false;
        if (!col.gameObject.CompareTag("Quadrado")) { Pontos.pontuacao--; }
    }
}
