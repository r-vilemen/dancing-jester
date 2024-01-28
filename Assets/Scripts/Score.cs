using UnityEngine;

public class Score : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
       //Debug.Log(colisao_.points);
        if (Pontos.pontuacao > 5)
        {
            MudarCor(Color.green);
        }
        else if (Pontos.pontuacao < 5)
        {
            MudarCor(Color.red);
        }
    }

    void MudarCor(Color novaCor)
    {
        // Atribui a nova cor ao SpriteRenderer
        spriteRenderer.color = novaCor;
    }
    

}
