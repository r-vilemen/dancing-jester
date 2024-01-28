using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Downy : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Deadline"))
        {
            Pontos.pontuacao--;
            Destroy(gameObject);
        }
    }
}
