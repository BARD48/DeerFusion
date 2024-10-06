using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Serialization;

namespace UI
{
    public class UIController : MonoBehaviour
    {
        private RectTransform _filling;
        private PlayerController _player;
        private void Awake()
        {
            _player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
            _filling = GameObject.FindGameObjectWithTag("HealthBar").GetComponent<RectTransform>();
        }

        private void Start()
        {
            _filling.localScale = new Vector3(_player.Health,_filling.localScale.y, _filling.localScale.z);
        }
        
        
    }
}
