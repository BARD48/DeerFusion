using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    public GameObject meteorPrefab; // Meteor prefab�
    public float spawnInterval = 2f; // Spawn aral���
    public float spawnRangeX = 8f; // X aral���
    public Vector3 movementSpeed = new Vector3(0, 0, 5.0f);
    public int meteorSpawnNumber = 30; // Spawn edilecek meteor say�s�

    private void Start()
    {
        StartCoroutine(SpawnMeteorAtRandomX());
    }

    private IEnumerator SpawnMeteorAtRandomX()
    {
        for (int i = 0; i < meteorSpawnNumber; i++)
        {
            // Rastgele X konumu belirle
            float randomX = Random.Range(-spawnRangeX, spawnRangeX);
            Vector3 spawnPosition = new Vector3(randomX, 0.15f, 0.0f);

            // Meteor prefab�n� belirlenen pozisyonda instantiate et
            GameObject meteorInstance = Instantiate(meteorPrefab, spawnPosition, Quaternion.identity);
            meteorInstance.transform.localRotation = Quaternion.Euler(90, 270, 0);
            // Meteorun Rigidbody bile�eni olup olmad���n� kontrol et
            Rigidbody rb = meteorInstance.GetComponent<Rigidbody>();

            // E�er Rigidbody yoksa, ekle
            if (rb == null)
            {
                rb = meteorInstance.AddComponent<Rigidbody>();
            }

            // Rigidbody kullanarak yer�ekimi ve h�z ayarlar�n� yap
            rb.useGravity = false; // Yer�ekimini iptal et
            rb.velocity = movementSpeed; // Meteorun hareket h�z�n� ayarla

            // Belirtilen aral�kla bekle
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}




