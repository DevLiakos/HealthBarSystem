using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider HealthBarSlider;
    public Slider HealthBarYellowSlider;

    private void Update()
    {
        if (Input.GetKeyDown("q"))
            StartCoroutine(AddHealth());

        if (Input.GetKeyDown("w"))
            StartCoroutine(SubtractHealth());
    }

    private IEnumerator AddHealth()
    {
        for(int i = 0; i < 100; i++)
        {
            HealthBarSlider.value += 0.1f;
            HealthBarYellowSlider.value += 0.1f;
            yield return new WaitForSeconds(0.003f);
        }
    }

    private IEnumerator SubtractHealth()
    {
        HealthBarSlider.value -= 10;
        yield return new WaitForSeconds(0.3f);

        for(int i = 0; i < 100; i++)
        {
            HealthBarYellowSlider.value -= 0.1f;
            yield return new WaitForSeconds(0.003f);
        }
    }
}
