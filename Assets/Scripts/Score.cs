using UnityEngine;

public class Score : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Colisao colisao_;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Debug.Log(colisao_.points);
        if (colisao_.points >= 1)
        {
            MudarCor(Color.green);
        }
        else if (colisao_.points < -1)
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
