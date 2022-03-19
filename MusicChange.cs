using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicChange : MonoBehaviour
{
    [SerializeField] private GameObject M1, M2, M3, M4, M5;
    [SerializeField] private DayChange DC;

    void Update()
    {
        if (DC.dayCount == 1 || DC.dayCount == 6 || DC.dayCount == 11)
        {
            M1.SetActive(true);
            M2.SetActive(false);
            M3.SetActive(false);
            M4.SetActive(false);
            M5.SetActive(false);
        }
        else if (DC.dayCount == 2 || DC.dayCount == 7 || DC.dayCount == 12)
        {
            M1.SetActive(false);
            M2.SetActive(true);
            M3.SetActive(false);
            M4.SetActive(false);
            M5.SetActive(false);
        }
        else if (DC.dayCount == 3 || DC.dayCount == 8 || DC.dayCount == 13)
        {
            M1.SetActive(false);
            M2.SetActive(false);
            M3.SetActive(true);
            M4.SetActive(false);
            M5.SetActive(false);
        }
        else if (DC.dayCount == 4 || DC.dayCount == 9 || DC.dayCount == 14)
        {
            M1.SetActive(false);
            M2.SetActive(false);
            M3.SetActive(false);
            M4.SetActive(true);
            M5.SetActive(false);
        }
        else if (DC.dayCount == 5 || DC.dayCount == 10 || DC.dayCount == 15)
        {
            M1.SetActive(false);
            M2.SetActive(false);
            M3.SetActive(false);
            M4.SetActive(false);
            M5.SetActive(true);
        }
    }
}
