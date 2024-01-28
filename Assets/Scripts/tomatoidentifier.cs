using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tomatoidentifier : MonoBehaviour
{
    public GameObject TomatoParticle;



    void Start()
    {

    }

    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "tomato")
        {
            TomatoParticle.SetActive(true);
            Destroy(col.gameObject);
            Invoke("FuncaoBraba", 10f);
        }
    }
    void FuncaoBraba()
    {

        TomatoParticle.SetActive(false);
    }
}