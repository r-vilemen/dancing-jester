using UnityEngine;

public class ParticleSystem_ : MonoBehaviour
{
    public ParticleSystem sistemaDeParticulas;


    void Start()
    {
        sistemaDeParticulas = GetComponent<ParticleSystem>();

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AtivarParticulas();
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            DesativarParticulas();
        }
    }

    void AtivarParticulas()
    {
        sistemaDeParticulas.Play();
    }

    void DesativarParticulas()
    {
        sistemaDeParticulas.Stop();
    }
}
