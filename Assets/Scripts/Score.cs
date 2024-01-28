using UnityEngine;

public class Score : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public GameObject ImagemFeliz;
    public GameObject ImagemNormal;
    public GameObject ImagemLaranja;
    public GameObject ImagemVermelha;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        ImagemNormal.SetActive(true);
    }

    void Update()
    {

       //Debug.Log(colisao_.points);
        if (Pontos.pontuacao > 5)
        {
            ImagemFeliz.SetActive(true);
            ImagemNormal.SetActive(false);
            ImagemLaranja.SetActive(false);
            ImagemVermelha.SetActive(false);

        }
        else if(Pontos.pontuacao == 5)
        {
            ImagemNormal.SetActive(true);
            ImagemFeliz.SetActive(false);
            ImagemLaranja.SetActive(false);
            ImagemVermelha.SetActive(false);
        }
        else if (Pontos.pontuacao < 5 && Pontos.pontuacao > 1)
        {
            ImagemNormal.SetActive(false);
            ImagemFeliz.SetActive(false);
            ImagemLaranja.SetActive(true);
            ImagemVermelha.SetActive(false);
        }
        else if (Pontos.pontuacao <= 1)
        {
            ImagemNormal.SetActive(false);
            ImagemFeliz.SetActive(false);
            ImagemLaranja.SetActive(false);
            ImagemVermelha.SetActive(true);
        }
    }

    void MudarCor(Color novaCor)
    {
        // Atribui a nova cor ao SpriteRenderer
        spriteRenderer.color = novaCor;
    }
    

}
