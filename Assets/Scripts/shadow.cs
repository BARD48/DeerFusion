using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowZone : MonoBehaviour
{

    // Astronot g�lge b�lgesine girdi�inde �al���r
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {

            Debug.Log("Cube Collided");
        }
        
        
    }
}

