using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoodSlider : MonoBehaviour
{
    public PlayerStats PS;
    [SerializeField] private Slider moodSlider;
    void Start()
    {
        moodSlider = GetComponent<Slider>();
    }

    void Update()
    {
        moodSlider.value = PS.moodValue;
    }
}
