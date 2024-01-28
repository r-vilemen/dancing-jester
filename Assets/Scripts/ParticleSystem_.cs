using UnityEngine;

public class ParticleSystem_ : MonoBehaviour
{
    public ParticleSystem sistemaDeParticulas;


    void Start()
    {
        // Obtém o componente ParticleSystem do objeto
        sistemaDeParticulas = GetComponent<ParticleSystem>();

        // Certifique-se de que o sistema de partículas não esteja reproduzindo no início
    }

    void Update()
    {
        // Exemplo: Ativar partículas quando pressionar a tecla "Espaço"
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AtivarParticulas();
        }

        // Exemplo: Desativar partículas quando pressionar a tecla "D"
        if (Input.GetKeyDown(KeyCode.M))
        {
            DesativarParticulas();
        }
    }

    void AtivarParticulas()
    {
        // Inicia o sistema de partículas
        sistemaDeParticulas.Play();
    }

    void DesativarParticulas()
    {
        // Para o sistema de partículas
        sistemaDeParticulas.Stop();
    }
}
