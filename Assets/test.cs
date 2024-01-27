using UnityEngine;

public class test : MonoBehaviour
{
    private bool podePressionar = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow) && podePressionar)
        {
            Debug.Log("Acertou!");
            // Aqui, você pode adicionar a lógica para quando o jogador acertar a tecla no momento certo.
            // Por exemplo, pontuação, animações, etc.
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Obstaculo"))
        {
            podePressionar = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Obstaculo"))
        {
            podePressionar = false;
            Debug.Log("Você perdeu!");
            // Aqui, você pode adicionar a lógica para quando o jogador perde por não pressionar a tecla no momento certo.
            // Por exemplo, reiniciar o jogo, mostrar pontuação final, etc.
        }
    }
}