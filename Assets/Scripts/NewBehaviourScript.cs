using UnityEngine;

public class BarrierController : MonoBehaviour
{
    // Bu değişkenle engellemeyi açıp kapatabilirsiniz
    public bool isBarrierActive = true;

    // Collider'a girildiğinde çağrılır
    void OnTriggerEnter(Collider other)
    {
        if (isBarrierActive && other.gameObject.tag == "Player")
        {
            // Geçişi engelle
            Debug.Log("Geçiş engellendi!");

            // Örneğin, oyuncuyu geri itmek için Rigidbody'yi kullanabilirsiniz
            Rigidbody playerRigidbody = other.GetComponent<Rigidbody>();
            if (playerRigidbody != null)
            {
                // Oyuncuyu geri iter
                Vector3 pushDirection = other.transform.position - transform.position;
                playerRigidbody.AddForce(pushDirection.normalized * 500f); // Kuvvet ayarlanabilir
            }
        }
    }

    // Collider'dan çıkıldığında çağrılır
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Oyuncu bariyerden ayrıldı.");
        }
    }
}
