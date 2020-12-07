using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace StatePattern
{
    public class Health : MonoBehaviour
    {
        Slider slider;
        Weapon wp;
        public static float numberHealth = 100f;

        private void Start()
        {
            slider = GetComponent<Slider>();
            slider.interactable = false;
        }
        private void Update()
        {
            slider.value = numberHealth;
        }
    }
}
