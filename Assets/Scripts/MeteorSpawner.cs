using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    public GameObject meteorPrefab; // Meteor prefabý
    public float spawnInterval = 2f; // Spawn aralýðý
    public float spawnRangeX = 8f; // X aralýðý
    public Vector3 movementSpeed = new Vector3(0, 0, 5.0f);
    public int meteorSpawnNumber = 30; // Spawn edilecek meteor sayýsý

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

            // Meteor prefabýný belirlenen pozisyonda instantiate et
            GameObject meteorInstance = Instantiate(meteorPrefab, spawnPosition, Quaternion.identity);
            meteorInstance.transform.localRotation = Quaternion.Euler(90, 270, 0);
            // Meteorun Rigidbody bileþeni olup olmadýðýný kontrol et
            Rigidbody rb = meteorInstance.GetComponent<Rigidbody>();

            // Eðer Rigidbody yoksa, ekle
            if (rb == null)
            {
                rb = meteorInstance.AddComponent<Rigidbody>();
            }

            // Rigidbody kullanarak yerçekimi ve hýz ayarlarýný yap
            rb.useGravity = false; // Yerçekimini iptal et
            rb.velocity = movementSpeed; // Meteorun hareket hýzýný ayarla

            // Belirtilen aralýkla bekle
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}




