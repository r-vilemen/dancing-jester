using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadLine : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        Destroy(col.gameObject);
        if (!col.gameObject.CompareTag("Quadrado")) { AddPoints(-1); }
    }
    void AddPoints(int points) => Pontos.pontuacao += points;
}
