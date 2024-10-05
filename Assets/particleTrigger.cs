using UnityEngine;

public class TriggerParticle : MonoBehaviour
{
    public ParticleSystem particleSystem; // Particle System referansı

    private void OnTriggerEnter(Collider collision)
    {
        // Eğer player Cube objesine dokunduysa
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.localRotation = Quaternion.Euler()
            // Particle System'i başlat
            if (particleSystem != null)
            {
                particleSystem.Play();
            }
        }
    }
}
