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
}
