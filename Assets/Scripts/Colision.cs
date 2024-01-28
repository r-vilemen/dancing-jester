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

    [SerializeField] private GameObject reference;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            leftpressed = true;
            VerifyObject();
            return;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow)) leftpressed = false;

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            downpressed = true;
            VerifyObject();
            return;
        }
        if (Input.GetKeyUp(KeyCode.DownArrow)) downpressed = false;

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rightpressed = true;
            VerifyObject();
            return;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow)) rightpressed = false;

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            uppressed = true;
            VerifyObject();
            return;
        }
        if (Input.GetKeyUp(KeyCode.UpArrow)) uppressed = false;

    }
    void AddPoints(int points) => Pontos.pontuacao += points; //{ } equivale => se for uma linha
    void VerifyObject() 
    {
        if (reference == null) AddPoints(-1);

        if(leftpressed && reference.tag == "SetaEsq")
        {
            AddPoints(1);
        }
        else if (rightpressed && reference.tag == "SetaDir")
        {
            AddPoints(1);
        }
        else if (uppressed && reference.tag == "SetaUp")
        {
            AddPoints(1);
        }
        else if (downpressed && reference.tag == "SetaDown")
        {
            AddPoints(1);
        }
        else if (reference.tag == "Quadrado")
        {
            AddPoints(-1); //adicionar numero negativo e como se fosse subtracao
        }
        DestroyItem();
    }
    void DestroyItem() {
        if (reference == null) return;
        Destroy(reference.gameObject);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        reference = col.gameObject;
    }
}
