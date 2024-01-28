using UnityEngine;

public class Pontos : MonoBehaviour
{
    public static int pontuacao;
    // Start is called before the first frame update
    void Start()
    {
        pontuacao = 5;

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(pontuacao);
        if(pontuacao < 0)
        {
            pontuacao = 0;
        }
        else if(pontuacao > 10)
        {
            pontuacao = 10;
        }
    }

}
