using UnityEngine;

public class TriggerParticle : MonoBehaviour
{
    public ParticleSystem particleSystem; // Particle System referansı

    private void OnCollisionEnter(Collision collision)
    {
        // Eğer player Cube objesine dokunduysa
        if (collision.gameObject.CompareTag("Player"))
        {
            // Particle System'i başlat
            if (particleSystem != null)
            {
                particleSystem.Play();
            }
        }
    }
}
