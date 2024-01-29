using UnityEngine;

public class Ketchup_Destroyer : MonoBehaviour
{
    public GameObject objetoParaAtivar;
    public ParticleSystem particleSystem;

    void Start()
    {
        // Obtenha a referência para o componente ParticleSystem.
        if (particleSystem == null)
        {
            particleSystem = GetComponentInChildren<ParticleSystem>();
        }

        // Certifique-se de que o sistema de partículas não esteja reproduzindo no início.
        if (particleSystem.isPlaying)
        {
            particleSystem.Stop();
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("tomato"))
        {
            Debug.Log("Tomato destroyed");
            Destroy(collision.gameObject);

            Invoke("PlayParticles", 0f);
        }
    }

    void PlayParticles()
    {
        // Inicie o sistema de partículas.
        if (!particleSystem.isPlaying)
        {
            particleSystem.Play();
        }

        // Agende a parada das partículas após 2 segundos (ou ajuste conforme necessário).
        Invoke("StopParticles", .5f);
    }

    void StopParticles()
    {
        // Pare o sistema de partículas.
        if (particleSystem.isPlaying)
        {
            particleSystem.Stop();
        }

    }
}
