using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject telaDerrota;
    public GameObject telaVitoria;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(terminarfase());
        Time.timeScale = 1f;
        telaDerrota.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Pontos.pontuacao <= -2)
        {
            telaDerrota.SetActive(true);
            Time.timeScale = 0f;
        }
        
    }
    IEnumerator terminarfase()
    {
        yield return new WaitForSeconds(60);
        telaVitoria.SetActive(true);
        Time.timeScale = 0f;
    }
}
