using UnityEngine;

public class ControladorTransparencia : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private bool aumentandoAlfa = true;

    void Start()
    {
        // Obtém o componente SpriteRenderer do GameObject
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Se a seta esquerda for pressionada, altera a transparência (alfa)
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            AlternarAlfa();
        }
    }

    void AlternarAlfa()
    {
        // Verifica se está aumentando ou diminuindo o alfa
        if (aumentandoAlfa)
        {
            // Aumenta o alfa gradualmente
            spriteRenderer.color = new Color(
                spriteRenderer.color.r,
                spriteRenderer.color.g,
                spriteRenderer.color.b,
                spriteRenderer.color.a + Time.deltaTime * 50f);

            // Se atingir o valor máximo (1.0), inicia a diminuição
            if (spriteRenderer.color.a >= 1.0f)
            {
                aumentandoAlfa = false;
            }
        }
        else
        {
            // Diminui o alfa gradualmente
            spriteRenderer.color = new Color(
                spriteRenderer.color.r,
                spriteRenderer.color.g,
                spriteRenderer.color.b,
                spriteRenderer.color.a - Time.deltaTime * 50f);

            // Se atingir o valor mínimo (0), reinicia o aumento
            if (spriteRenderer.color.a <= 0.0f)
            {
                aumentandoAlfa = true;
            }
        }
    }
}
