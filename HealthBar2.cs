using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar2 : MonoBehaviour
{
    private Slider HealthBarSlider;

    private void Start()
    {
        HealthBarSlider = gameObject.GetComponent<Slider>();
    }

    private void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            AddHealth();
        }

        if (Input.GetKeyDown("w"))
        {
            SubtractHealth();
        }
    }

    private void AddHealth()
    {
        HealthBarSlider.value += 10;
    }

    private void SubtractHealth()
    {
        HealthBarSlider.value -= 10;
    }
}
