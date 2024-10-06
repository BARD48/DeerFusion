using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowZone : MonoBehaviour
{

    // Astronot gölge bölgesine girdiðinde çalýþýr
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {

            Debug.Log("Cube Collided");
        }
        
        
    }
}

