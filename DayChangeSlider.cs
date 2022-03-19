using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DayChangeSlider : MonoBehaviour
{
    public Slider daySlider;
    void Start()
    {
        daySlider = GetComponent<Slider>();
        daySlider.value = 0;
    }

    void Update()
    {
        daySlider.value += Time.deltaTime;
        if (daySlider.value >= 25)
            daySlider.value = 0;
    }
}
