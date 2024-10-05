using System.Collections;
using Cinemachine;
using UnityEngine;
using UnityEngine.Serialization;

public class TriggerParticle : MonoBehaviour
{
    public ParticleSystem particleSystem; // Particle System referansı
    [SerializeField] private GameObject cubeCloseCam;
    [SerializeField] private GameObject cubeFarCam;
    
    private void OnTriggerEnter(Collider other)
    {
        
        // Eğer player Cube objesine dokunduysa
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Cube Collided");
            // Particle System'i başlat
            if (particleSystem != null)
            {
                particleSystem.Play();
            }

            StartCoroutine(SwitchCam());
        }
    }

    IEnumerator SwitchCam()
    {
        yield return new WaitForSeconds(1f);
        cubeCloseCam.SetActive(false);
        cubeFarCam.SetActive(true);
    }
}
